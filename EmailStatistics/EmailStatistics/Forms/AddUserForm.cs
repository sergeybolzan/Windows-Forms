using EmailStatistics.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailStatistics.Forms
{
    public partial class AddUserForm : Form
    {
        private UserInfo userInfo;
        public UserInfo UserInfo
        {
            get { return userInfo; }
            set { userInfo = value; }
        }
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                userInfo = new UserInfo()
                {
                    Name = tbName.Text,
                    Email = tbEmail.Text
                };

                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
