namespace BanksSearchApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tscbSelectAction = new System.Windows.Forms.ToolStripComboBox();
            this.tscbSelectCurrency = new System.Windows.Forms.ToolStripComboBox();
            this.tsbtnShow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnShowMin = new System.Windows.Forms.ToolStripButton();
            this.tsbtnShowMax = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnUpdateData = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbSelectAction,
            this.tscbSelectCurrency,
            this.tsbtnShow,
            this.toolStripSeparator3,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.tsbtnShowMin,
            this.tsbtnShowMax,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.tsbtnUpdateData});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1121, 29);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tscbSelectAction
            // 
            this.tscbSelectAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbSelectAction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tscbSelectAction.Items.AddRange(new object[] {
            "Продать",
            "Купить"});
            this.tscbSelectAction.Name = "tscbSelectAction";
            this.tscbSelectAction.Size = new System.Drawing.Size(121, 29);
            // 
            // tscbSelectCurrency
            // 
            this.tscbSelectCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbSelectCurrency.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tscbSelectCurrency.Items.AddRange(new object[] {
            "1 Доллар США",
            "1 Евро",
            "100 Российских рублей"});
            this.tscbSelectCurrency.Name = "tscbSelectCurrency";
            this.tscbSelectCurrency.Size = new System.Drawing.Size(200, 29);
            // 
            // tsbtnShow
            // 
            this.tsbtnShow.AutoToolTip = false;
            this.tsbtnShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbtnShow.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShow.Image")));
            this.tsbtnShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShow.Name = "tsbtnShow";
            this.tsbtnShow.Size = new System.Drawing.Size(82, 26);
            this.tsbtnShow.Text = "Показать";
            this.tsbtnShow.Click += new System.EventHandler(this.tsbtnShow_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbtnShowMin
            // 
            this.tsbtnShowMin.AutoToolTip = false;
            this.tsbtnShowMin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShowMin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbtnShowMin.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShowMin.Image")));
            this.tsbtnShowMin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowMin.Name = "tsbtnShowMin";
            this.tsbtnShowMin.Size = new System.Drawing.Size(164, 26);
            this.tsbtnShowMin.Text = "Минимальный курс";
            this.tsbtnShowMin.Click += new System.EventHandler(this.tsbtnShowMin_Click);
            // 
            // tsbtnShowMax
            // 
            this.tsbtnShowMax.AutoToolTip = false;
            this.tsbtnShowMax.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShowMax.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbtnShowMax.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShowMax.Image")));
            this.tsbtnShowMax.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowMax.Name = "tsbtnShowMax";
            this.tsbtnShowMax.Size = new System.Drawing.Size(169, 26);
            this.tsbtnShowMax.Text = "Максимальный курс";
            this.tsbtnShowMax.Click += new System.EventHandler(this.tsbtnShowMax_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbtnUpdateData
            // 
            this.tsbtnUpdateData.AutoToolTip = false;
            this.tsbtnUpdateData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnUpdateData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbtnUpdateData.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdateData.Image")));
            this.tsbtnUpdateData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdateData.Name = "tsbtnUpdateData";
            this.tsbtnUpdateData.Size = new System.Drawing.Size(148, 26);
            this.tsbtnUpdateData.Text = "Обновить данные";
            this.tsbtnUpdateData.Click += new System.EventHandler(this.tsbtnUpdateData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 737);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карта банков";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripComboBox tscbSelectAction;
        private System.Windows.Forms.ToolStripComboBox tscbSelectCurrency;
        private System.Windows.Forms.ToolStripButton tsbtnShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnShowMin;
        private System.Windows.Forms.ToolStripButton tsbtnShowMax;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbtnUpdateData;

    }
}

