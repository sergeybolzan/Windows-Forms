using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace EmailStatistics.Entities
{
    public static class Mail
    {
        /// <summary>
        /// Отправка письма по данным события.
        /// </summary>
        /// <param name="userEvent"></param>
        public static void SendMail(UserEvent userEvent)
        {
            try
            {
                //Создание SMTP  клиента (выбираем один из SMTP-серверов)                
                SmtpClient Smtp = new SmtpClient(userEvent.EventServerSettings.MailServerSettings.Address, userEvent.EventServerSettings.MailServerSettings.Port);
                // авторизируем подключение, указываем email и пароль, 
                // которые были ранее зарегистрированы (можно воспользоваться указанными!!!)                             
                Smtp.Credentials = new NetworkCredential(userEvent.EventServerSettings.Account, userEvent.EventServerSettings.Password);
                //включаем поддержку SSL (некоторые сервера это требуют)                             
                Smtp.EnableSsl = userEvent.EventServerSettings.MailServerSettings.IsEnabledSSL;

                //Формирование письма
                MailMessage message = new MailMessage();
                //указываем адрес отправителя!
                message.From = new MailAddress("ivanitstep@mail.ru");

                //указываем адрес получателя!
                var emailsList = userEvent.Emails.Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var email in emailsList)
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
