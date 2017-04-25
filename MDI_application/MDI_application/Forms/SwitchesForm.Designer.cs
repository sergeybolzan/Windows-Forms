namespace MDI_application.Forms
{
    partial class SwitchesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSwitches = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwitches)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSwitches
            // 
            this.dgvSwitches.AllowUserToAddRows = false;
            this.dgvSwitches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSwitches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSwitches.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSwitches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSwitches.Location = new System.Drawing.Point(0, 0);
            this.dgvSwitches.MultiSelect = false;
            this.dgvSwitches.Name = "dgvSwitches";
            this.dgvSwitches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSwitches.Size = new System.Drawing.Size(915, 599);
            this.dgvSwitches.TabIndex = 0;
            this.dgvSwitches.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvSwitches_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // сmiDelete
            // 
            this.сmiDelete.Name = "сmiDelete";
            this.сmiDelete.Size = new System.Drawing.Size(118, 22);
            this.сmiDelete.Text = "Удалить";
            this.сmiDelete.Click += new System.EventHandler(this.сmiDelete_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveChanges);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSwitches);
            this.splitContainer1.Size = new System.Drawing.Size(915, 628);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveChanges.Location = new System.Drawing.Point(0, 0);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(131, 25);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // SwitchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(915, 628);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "SwitchesForm";
            this.Text = "Список коммутаторов";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwitches)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSwitches;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сmiDelete;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}