using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailStatistics.Entities
{
    /// <summary>
    /// Статический класс, содержащий статические методы для работы с узлами дерева.
    /// </summary>
    public static class Logic
    {
        public static string selNames { get; set; }
        public static string selEmails { get; set; }

        /// <summary>
        /// Получение строки с именами в соответсвии с отмеченными узлами дерева.
        /// </summary>
        /// <param name="selTN"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Получение строки с емейлами в соответсвии с отмеченными узлами дерева.
        /// </summary>
        /// <param name="selTN"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Метод, отмечающий родительский узел, если некоторый узел отметили, и его соседи также отмечены.
        /// При наличии всех отмеченных дочерних узлов и снятия отметки с одного из них, отметка с родителя также снимается.
        /// </summary>
        /// <param name="e"></param>
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
    }
}
