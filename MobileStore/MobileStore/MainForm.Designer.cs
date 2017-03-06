namespace MobileStore
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
            this.labelList = new System.Windows.Forms.Label();
            this.listBoxPhones = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeletePhone = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbOS = new System.Windows.Forms.TextBox();
            this.tbProcessor = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelOS = new System.Windows.Forms.Label();
            this.labelProcessor = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelOptions = new System.Windows.Forms.Label();
            this.listBoxOptions = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(14, 9);
            this.labelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(67, 16);
            this.labelList.TabIndex = 0;
            this.labelList.Text = "labelList";
            // 
            // listBoxPhones
            // 
            this.listBoxPhones.FormattingEnabled = true;
            this.listBoxPhones.ItemHeight = 16;
            this.listBoxPhones.Location = new System.Drawing.Point(17, 31);
            this.listBoxPhones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxPhones.Name = "listBoxPhones";
            this.listBoxPhones.Size = new System.Drawing.Size(245, 324);
            this.listBoxPhones.TabIndex = 1;
            this.listBoxPhones.SelectedIndexChanged += new System.EventHandler(this.listBoxPhones_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(295, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 499);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxOptions);
            this.tabPage1.Controls.Add(this.labelOptions);
            this.tabPage1.Controls.Add(this.labelPrice);
            this.tabPage1.Controls.Add(this.labelProcessor);
            this.tabPage1.Controls.Add(this.labelOS);
            this.tabPage1.Controls.Add(this.labelModel);
            this.tabPage1.Controls.Add(this.tbPrice);
            this.tabPage1.Controls.Add(this.tbProcessor);
            this.tabPage1.Controls.Add(this.tbOS);
            this.tabPage1.Controls.Add(this.tbModel);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(391, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(391, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeletePhone
            // 
            this.btnDeletePhone.Location = new System.Drawing.Point(17, 375);
            this.btnDeletePhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletePhone.Name = "btnDeletePhone";
            this.btnDeletePhone.Size = new System.Drawing.Size(113, 44);
            this.btnDeletePhone.TabIndex = 3;
            this.btnDeletePhone.Text = "btnDeletePhone";
            this.btnDeletePhone.UseVisualStyleBackColor = true;
            this.btnDeletePhone.Click += new System.EventHandler(this.btnDeletePhone_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(149, 375);
            this.btnClearList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(113, 44);
            this.btnClearList.TabIndex = 4;
            this.btnClearList.Text = "btnClearList";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(17, 451);
            this.btnSaveToFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(113, 44);
            this.btnSaveToFile.TabIndex = 5;
            this.btnSaveToFile.Text = "btnSaveToFile";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.Location = new System.Drawing.Point(149, 451);
            this.btnReadFromFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(113, 44);
            this.btnReadFromFile.TabIndex = 6;
            this.btnReadFromFile.Text = "btnReadFromFile";
            this.btnReadFromFile.UseVisualStyleBackColor = true;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(189, 188);
            this.tbModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(182, 22);
            this.tbModel.TabIndex = 1;
            // 
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(189, 218);
            this.tbOS.Margin = new System.Windows.Forms.Padding(4);
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(182, 22);
            this.tbOS.TabIndex = 2;
            // 
            // tbProcessor
            // 
            this.tbProcessor.Location = new System.Drawing.Point(189, 248);
            this.tbProcessor.Margin = new System.Windows.Forms.Padding(4);
            this.tbProcessor.Name = "tbProcessor";
            this.tbProcessor.Size = new System.Drawing.Size(182, 22);
            this.tbProcessor.TabIndex = 3;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(189, 278);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(182, 22);
            this.tbPrice.TabIndex = 4;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(19, 194);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(86, 16);
            this.labelModel.TabIndex = 5;
            this.labelModel.Text = "labelModel";
            // 
            // labelOS
            // 
            this.labelOS.AutoSize = true;
            this.labelOS.Location = new System.Drawing.Point(19, 224);
            this.labelOS.Name = "labelOS";
            this.labelOS.Size = new System.Drawing.Size(64, 16);
            this.labelOS.TabIndex = 6;
            this.labelOS.Text = "labelOS";
            // 
            // labelProcessor
            // 
            this.labelProcessor.AutoSize = true;
            this.labelProcessor.Location = new System.Drawing.Point(19, 254);
            this.labelProcessor.Name = "labelProcessor";
            this.labelProcessor.Size = new System.Drawing.Size(114, 16);
            this.labelProcessor.TabIndex = 7;
            this.labelProcessor.Text = "labelProcessor";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(19, 284);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(79, 16);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "labelPrice";
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Location = new System.Drawing.Point(7, 319);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(96, 16);
            this.labelOptions.TabIndex = 9;
            this.labelOptions.Text = "labelOptions";
            // 
            // listBoxOptions
            // 
            this.listBoxOptions.FormattingEnabled = true;
            this.listBoxOptions.ItemHeight = 16;
            this.listBoxOptions.Location = new System.Drawing.Point(10, 339);
            this.listBoxOptions.Name = "listBoxOptions";
            this.listBoxOptions.Size = new System.Drawing.Size(361, 116);
            this.listBoxOptions.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 558);
            this.Controls.Add(this.btnReadFromFile);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnDeletePhone);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBoxPhones);
            this.Controls.Add(this.labelList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile STORE";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.ListBox listBoxPhones;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeletePhone;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbProcessor;
        private System.Windows.Forms.TextBox tbOS;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelProcessor;
        private System.Windows.Forms.Label labelOS;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ListBox listBoxOptions;
        private System.Windows.Forms.Label labelOptions;
    }
}

