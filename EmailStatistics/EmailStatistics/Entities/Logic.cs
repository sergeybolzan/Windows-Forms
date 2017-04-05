using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailStatistics.Entities
{
    public static class Logic
    {
        public static string selNames { get; set; }
        public static string selEmails { get; set; }
        public static string GetAllNames(TreeNode selTN)
        {
            for (int i = 0; i < selTN.Nodes.Count; i++)
            {
                GetAllNames(selTN.Nodes[i]);
                if (selTN.Nodes[i].Level >= 3 && selTN.Nodes[i].Checked)
                {
                    selNames += selTN.Nodes[i].Text + "; ";
                }
            }
            return selNames;
        }

        public static string GetAllEmails(TreeNode selTN)
        {
            for (int i = 0; i < selTN.Nodes.Count; i++)
            {
                GetAllEmails(selTN.Nodes[i]);
                if (selTN.Nodes[i].Level >= 3 && selTN.Nodes[i].Checked)
                {
                    selEmails += selTN.Nodes[i].Tag + "; ";
                }
            }
            return selEmails;
        }

        /// <summary>
        /// Рекурсивный метод установки всех дочерних узлов узла treeNode в состояние nodeChecked
        /// </summary>
        /// <param name="treeNode">Узел, состояние дочерних узлов которого необходимо изменить</param>
        /// <param name="nodeChecked">Состояние, в которое будут изменяться дочерние узлы</param>
        public static void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        /// <summary>
        /// Снимает все отметки с узла treeNode и с его дочерних узлов
        /// </summary>
        /// <param name="treeNode"></param>
        public static void UncheckAllNodes(TreeNode treeNode)
        {
            treeNode.Checked = false;
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = false;
                if (node.Nodes.Count > 0)
                {
                    UncheckAllNodes(node);
                }
            }
        }

        public static void CheckOrUncheckParentNode(TreeViewEventArgs e)
        {
            TreeNode parent = e.Node.Parent;
            while (parent != null) // Выполняем цикл, пока не дойдем до корневого узла
            {
                if (e.Node.Checked) // Если узел отметили, и все соседние узлы также отмечены, то отмечаем и родителя
                {
                    bool state = true;
                    foreach (TreeNode item in parent.Nodes)
                    {
                        if (!item.Checked) state = false;
                    }
                    if (state == true) parent.Checked = true;
                }
                else // А если отметку с узла сняли, то и с родителя также снимаем отметку
                {
                    parent.Checked = false;
                }
                parent = parent.Parent; // Для выполнения цикла, пока не дойдем до корневого узла
            }
        }

        public static void SendMail(UserEvent userEvent)
        {
            try
            {
                //Создание SMTP  клиента (выбираем один из SMTP-серверов)                
                SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 2525);
                // авторизируем подключение, указываем email и пароль, 
                // которые были ранее зарегистрированы (можно воспользоваться указанными!!!)                             
                Smtp.Credentials = new NetworkCredential("ivanitstep@mail.ru", "ivan123456789");
                //включаем поддержку SSL (некоторые сервера это требуют)                             
                Smtp.EnableSsl = true;

                //Формирование письма
                MailMessage message = new MailMessage();
                //указываем адрес отправителя!
                message.From = new MailAddress("ivanitstep@mail.ru");

                //указываем адрес получателя!
                foreach (var email in userEvent.EmailsList)
                {
                    message.To.Add(new MailAddress(email));
                }

                //указываем заголовок письма
                message.Subject = userEvent.MessageTheme;
                //указываем ТЕКСТ письма
                message.Body = userEvent.MessageText;

                // Прикрепление файла
                if (!String.IsNullOrEmpty(userEvent.FileName))
                {
                    Attachment attach = new Attachment(userEvent.FileName);
                    //// Добавляем информацию для файла (дополнительно!)
                    //ContentDisposition disposition = attach.ContentDisposition;
                    //// указываем дату создания 
                    //disposition.CreationDate = System.IO.File.GetCreationTime(userEvent.FileName);
                    ////добавление вложения
                    message.Attachments.Add(attach);
                }

                //отправка письма
                Smtp.Send(message);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
