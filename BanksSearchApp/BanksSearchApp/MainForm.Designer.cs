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
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbSelectAction,
            this.tscbSelectCurrency,
            this.tsbtnShow});
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
            this.tsbtnShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbtnShow.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShow.Image")));
            this.tsbtnShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShow.Name = "tsbtnShow";
            this.tsbtnShow.Size = new System.Drawing.Size(82, 26);
            this.tsbtnShow.Text = "Показать";
            this.tsbtnShow.Click += new System.EventHandler(this.tsbtnShow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 737);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карта банков";
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

    }
}

