namespace MDI_application.Forms
{
    partial class AddSwitchForm
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
            this.btnAddSwitch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirmware = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_IPaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVLAN_manag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVLANsubscr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFeatures = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddSwitch
            // 
            this.btnAddSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSwitch.Location = new System.Drawing.Point(482, 562);
            this.btnAddSwitch.Name = "btnAddSwitch";
            this.btnAddSwitch.Size = new System.Drawing.Size(216, 50);
            this.btnAddSwitch.TabIndex = 0;
            this.btnAddSwitch.Text = "Добавить коммутатор";
            this.btnAddSwitch.UseVisualStyleBackColor = true;
            this.btnAddSwitch.Click += new System.EventHandler(this.btnAddSwitch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адрес:";
            // 
            // tbFirmware
            // 
            this.tbFirmware.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFirmware.Location = new System.Drawing.Point(170, 332);
            this.tbFirmware.Name = "tbFirmware";
            this.tbFirmware.Size = new System.Drawing.Size(435, 22);
            this.tbFirmware.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(170, 84);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(435, 22);
            this.tbName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название:";
            // 
            // tb_IPaddress
            // 
            this.tb_IPaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_IPaddress.Location = new System.Drawing.Point(170, 134);
            this.tb_IPaddress.Name = "tb_IPaddress";
            this.tb_IPaddress.Size = new System.Drawing.Size(435, 22);
            this.tb_IPaddress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP-адрес:";
            // 
            // cmbVLAN_manag
            // 
            this.cmbVLAN_manag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVLAN_manag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbVLAN_manag.FormattingEnabled = true;
            this.cmbVLAN_manag.Location = new System.Drawing.Point(170, 184);
            this.cmbVLAN_manag.Name = "cmbVLAN_manag";
            this.cmbVLAN_manag.Size = new System.Drawing.Size(435, 24);
            this.cmbVLAN_manag.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(51, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "VLAN упр.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(51, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "VLAN абон.:";
            // 
            // tbVLANsubscr
            // 
            this.tbVLANsubscr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVLANsubscr.Location = new System.Drawing.Point(170, 234);
            this.tbVLANsubscr.Name = "tbVLANsubscr";
            this.tbVLANsubscr.Size = new System.Drawing.Size(435, 22);
            this.tbVLANsubscr.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(51, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Модель:";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(170, 282);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(435, 24);
            this.cmbModel.TabIndex = 12;
            // 
            // cmbAddress
            // 
            this.cmbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(170, 34);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(435, 24);
            this.cmbAddress.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(51, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Прошивка:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(51, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Особенности:";
            // 
            // tbFeatures
            // 
            this.tbFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFeatures.Location = new System.Drawing.Point(170, 382);
            this.tbFeatures.Name = "tbFeatures";
            this.tbFeatures.Size = new System.Drawing.Size(435, 22);
            this.tbFeatures.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(51, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Примечания:";
            // 
            // tbNotes
            // 
            this.tbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNotes.Location = new System.Drawing.Point(170, 432);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(435, 22);
            this.tbNotes.TabIndex = 17;
            // 
            // AddSwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 624);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbFeatures);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbAddress);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbVLANsubscr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbVLAN_manag);
            this.Controls.Add(this.tb_IPaddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFirmware);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddSwitch);
            this.Name = "AddSwitchForm";
            this.Text = "Добавить коммутатор";
            this.Activated += new System.EventHandler(this.AddSwitchForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirmware;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_IPaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVLAN_manag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVLANsubscr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFeatures;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNotes;
    }
}