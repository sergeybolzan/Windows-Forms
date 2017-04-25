using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_application.Forms
{
    public partial class AddModelOfSwitchForm : Form
    {
        private ToolStripMenuItem ParentButton_miAddmodel;
        public AddModelOfSwitchForm(ToolStripMenuItem miAddModel)
        {
            InitializeComponent();
            this.ParentButton_miAddmodel = miAddModel;
        }

        private void AddModelOfSwitchForm_Load(object sender, EventArgs e)
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                var models = db.Model.OrderBy(x => x.SwitchModel).Select(x => x.SwitchModel).ToList();
                lbModels.DataSource = models;
            }

        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbAddModel.Text))
            {
                using (SwitchEntities db = new SwitchEntities())
                {

                    Model model = new Model() { SwitchModel = tbAddModel.Text };
                    Model a = db.Model.Where(x => x.SwitchModel == model.SwitchModel).FirstOrDefault();
                    if (a == null)
                    {
                        db.Model.Add(model);
                        db.SaveChanges();
                        MessageBox.Show("Модель добавлена в базу");
                        var models = db.Model.OrderBy(x => x.SwitchModel).Select(x => x.SwitchModel).ToList();
                        lbModels.DataSource = models;
                    }
                    else MessageBox.Show("Такая модель коммутатора уже есть в базе");
                }
            }
            else MessageBox.Show("Введите модель коммутатора!");
        }

        private void AddModelOfSwitchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ParentButton_miAddmodel.Enabled = true;
        }
    }
}
