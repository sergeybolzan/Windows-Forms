namespace Autorization
{
    partial class RecoveryPasswordForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRepeatNewPassword = new System.Windows.Forms.TextBox();
            this.labelRepeatNewPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.tbEnterEmail = new System.Windows.Forms.TextBox();
            this.labelEnterEmail = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRepeatNewPassword);
            this.groupBox1.Controls.Add(this.labelRepeatNewPassword);
            this.groupBox1.Controls.Add(this.tbNewPassword);
            this.groupBox1.Controls.Add(this.labelNewPassword);
            this.groupBox1.Controls.Add(this.tbEnterEmail);
            this.groupBox1.Controls.Add(this.labelEnterEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbRepeatNewPassword
            // 
            this.tbRepeatNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRepeatNewPassword.Location = new System.Drawing.Point(6, 148);
            this.tbRepeatNewPassword.Name = "tbRepeatNewPassword";
            this.tbRepeatNewPassword.PasswordChar = '`';
            this.tbRepeatNewPassword.Size = new System.Drawing.Size(248, 26);
            this.tbRepeatNewPassword.TabIndex = 5;
            // 
            // labelRepeatNewPassword
            // 
            this.labelRepeatNewPassword.AutoSize = true;
            this.labelRepeatNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRepeatNewPassword.Location = new System.Drawing.Point(6, 132);
            this.labelRepeatNewPassword.Name = "labelRepeatNewPassword";
            this.labelRepeatNewPassword.Size = new System.Drawing.Size(161, 13);
            this.labelRepeatNewPassword.TabIndex = 4;
            this.labelRepeatNewPassword.Text = "Повторите новый пароль:";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewPassword.Location = new System.Drawing.Point(6, 90);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '`';
            this.tbNewPassword.Size = new System.Drawing.Size(248, 26);
            this.tbNewPassword.TabIndex = 3;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewPassword.Location = new System.Drawing.Point(6, 74);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(96, 13);
            this.labelNewPassword.TabIndex = 2;
            this.labelNewPassword.Text = "Новый пароль:";
            // 
            // tbEnterEmail
            // 
            this.tbEnterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEnterEmail.Location = new System.Drawing.Point(6, 32);
            this.tbEnterEmail.Name = "tbEnterEmail";
            this.tbEnterEmail.Size = new System.Drawing.Size(248, 26);
            this.tbEnterEmail.TabIndex = 1;
            // 
            // labelEnterEmail
            // 
            this.labelEnterEmail.AutoSize = true;
            this.labelEnterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnterEmail.Location = new System.Drawing.Point(6, 16);
            this.labelEnterEmail.Name = "labelEnterEmail";
            this.labelEnterEmail.Size = new System.Drawing.Size(93, 13);
            this.labelEnterEmail.TabIndex = 0;
            this.labelEnterEmail.Text = "Введите e-mail";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(116, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(197, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // RecoveryPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecoveryPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Восстановление пароля";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRepeatNewPassword;
        private System.Windows.Forms.Label labelRepeatNewPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox tbEnterEmail;
        private System.Windows.Forms.Label labelEnterEmail;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}