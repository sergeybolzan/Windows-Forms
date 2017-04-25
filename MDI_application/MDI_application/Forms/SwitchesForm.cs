using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace MDI_application.Forms
{
    public partial class SwitchesForm : Form
    {
        private SwitchEntities db;
        public SwitchesForm()
        {
            InitializeComponent();
            db = new SwitchEntities();
            db.Switch.Load();
            dgvSwitches.DataSource = db.Switch.Local.ToBindingList();
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            dgvSwitches.Columns["Address_ID"].Visible = false;
            dgvSwitches.Columns["Model_ID"].Visible = false;
            dgvSwitches.Columns["VLAN_manag_ID"].Visible = false;

            dgvSwitches.Columns["Address"].DisplayIndex = 1;
            dgvSwitches.Columns["Model"].DisplayIndex = 5;
            dgvSwitches.Columns["VLAN_manag"].DisplayIndex = 4;

            dgvSwitches.Columns["ID"].ReadOnly = true;
            dgvSwitches.Columns["Address"].ReadOnly = true;
            dgvSwitches.Columns["Model"].ReadOnly = true;
            dgvSwitches.Columns["VLAN_manag"].ReadOnly = true;

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }


        #region Обработчики нажатий по таблице
        private void dgvSwitches_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvSwitches.HitTest(e.X, e.Y);
                dgvSwitches.ClearSelection();
                if (hti.RowIndex > -1) dgvSwitches.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void сmiDelete_Click(object sender, EventArgs e)
        {
            int rowToDelete = dgvSwitches.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (rowToDelete > -1)
            {
                int idRowToDelete = (int)dgvSwitches.Rows[rowToDelete].Cells[0].Value;
                Switch selectedSwitch = db.Switch.Find(idRowToDelete);
                if (selectedSwitch == null) return;
                db.Switch.Remove(selectedSwitch);
                db.SaveChanges();
            }
        }
        #endregion
    }
}
