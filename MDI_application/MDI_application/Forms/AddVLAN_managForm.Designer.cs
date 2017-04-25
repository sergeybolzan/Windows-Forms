namespace MDI_application.Forms
{
    partial class AddVLAN_managForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddVLAN = new System.Windows.Forms.TextBox();
            this.btnAddVLAN = new System.Windows.Forms.Button();
            this.lbVLANs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(433, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите VLAN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список VLANов:";
            // 
            // tbAddVLAN
            // 
            this.tbAddVLAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddVLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddVLAN.Location = new System.Drawing.Point(436, 44);
            this.tbAddVLAN.Multiline = true;
            this.tbAddVLAN.Name = "tbAddVLAN";
            this.tbAddVLAN.Size = new System.Drawing.Size(357, 51);
            this.tbAddVLAN.TabIndex = 7;
            // 
            // btnAddVLAN
            // 
            this.btnAddVLAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddVLAN.Location = new System.Drawing.Point(573, 487);
            this.btnAddVLAN.Name = "btnAddVLAN";
            this.btnAddVLAN.Size = new System.Drawing.Size(220, 41);
            this.btnAddVLAN.TabIndex = 6;
            this.btnAddVLAN.Text = "Добавить VLAN";
            this.btnAddVLAN.UseVisualStyleBackColor = true;
            this.btnAddVLAN.Click += new System.EventHandler(this.btnAddVLAN_Click);
            // 
            // lbVLANs
            // 
            this.lbVLANs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVLANs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVLANs.FormattingEnabled = true;
            this.lbVLANs.ItemHeight = 16;
            this.lbVLANs.Location = new System.Drawing.Point(12, 44);
            this.lbVLANs.Name = "lbVLANs";
            this.lbVLANs.Size = new System.Drawing.Size(333, 468);
            this.lbVLANs.TabIndex = 5;
            // 
            // AddVLAN_managForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddVLAN);
            this.Controls.Add(this.btnAddVLAN);
            this.Controls.Add(this.lbVLANs);
            this.Name = "AddVLAN_managForm";
            this.Text = "Добавить VLAN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddVLAN_managForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddVLAN;
        private System.Windows.Forms.Button btnAddVLAN;
        private System.Windows.Forms.ListBox lbVLANs;
    }
}