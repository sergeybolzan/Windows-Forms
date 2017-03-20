using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorization.Entities
{
    public partial class MainApplicationForm : Form
    {
        public MainApplicationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Перегруженный метод для отображения в текстбоксе фамилии и имени
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DialogResult ShowDialog(string s)
        {
            textBox1.Text = s;
            return ShowDialog();
        }

    }
}
