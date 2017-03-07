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
            this.listBoxOptions = new System.Windows.Forms.ListBox();
            this.labelOptions = new System.Windows.Forms.Label();
            this.labelPrice1 = new System.Windows.Forms.Label();
            this.labelProcessor1 = new System.Windows.Forms.Label();
            this.labelOS1 = new System.Windows.Forms.Label();
            this.labelModel1 = new System.Windows.Forms.Label();
            this.tbPrice1 = new System.Windows.Forms.TextBox();
            this.tbProcessor1 = new System.Windows.Forms.TextBox();
            this.tbOS1 = new System.Windows.Forms.TextBox();
            this.tbModel1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeletePhone = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.labelPrice2 = new System.Windows.Forms.Label();
            this.labelProcessor2 = new System.Windows.Forms.Label();
            this.labelOS2 = new System.Windows.Forms.Label();
            this.labelModel2 = new System.Windows.Forms.Label();
            this.tbPrice2 = new System.Windows.Forms.TextBox();
            this.tbProcessor2 = new System.Windows.Forms.TextBox();
            this.tbOS2 = new System.Windows.Forms.TextBox();
            this.tbModel2 = new System.Windows.Forms.TextBox();
            this.checkedListBoxOptions = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelList.Location = new System.Drawing.Point(14, 9);
            this.labelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(154, 13);
            this.labelList.TabIndex = 0;
            this.labelList.Text = "Список телефонов магазина";
            // 
            // listBoxPhones
            // 
            this.listBoxPhones.FormattingEnabled = true;
            this.listBoxPhones.ItemHeight = 16;
            this.listBoxPhones.Location = new System.Drawing.Point(17, 31);
            this.listBoxPhones.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPhones.Name = "listBoxPhones";
            this.listBoxPhones.Size = new System.Drawing.Size(245, 324);
            this.listBoxPhones.TabIndex = 1;
            this.listBoxPhones.SelectedIndexChanged += new System.EventHandler(this.listBoxPhones_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(295, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 499);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxOptions);
            this.tabPage1.Controls.Add(this.labelOptions);
            this.tabPage1.Controls.Add(this.labelPrice1);
            this.tabPage1.Controls.Add(this.labelProcessor1);
            this.tabPage1.Controls.Add(this.labelOS1);
            this.tabPage1.Controls.Add(this.labelModel1);
            this.tabPage1.Controls.Add(this.tbPrice1);
            this.tabPage1.Controls.Add(this.tbProcessor1);
            this.tabPage1.Controls.Add(this.tbOS1);
            this.tabPage1.Controls.Add(this.tbModel1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(391, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация о телефоне";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxOptions
            // 
            this.listBoxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxOptions.FormattingEnabled = true;
            this.listBoxOptions.ItemHeight = 16;
            this.listBoxOptions.Location = new System.Drawing.Point(10, 339);
            this.listBoxOptions.Name = "listBoxOptions";
            this.listBoxOptions.Size = new System.Drawing.Size(361, 116);
            this.listBoxOptions.TabIndex = 10;
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOptions.Location = new System.Drawing.Point(7, 319);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(50, 16);
            this.labelOptions.TabIndex = 9;
            this.labelOptions.Text = "Опции";
            // 
            // labelPrice1
            // 
            this.labelPrice1.AutoSize = true;
            this.labelPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice1.ForeColor = System.Drawing.Color.Red;
            this.labelPrice1.Location = new System.Drawing.Point(19, 284);
            this.labelPrice1.Name = "labelPrice1";
            this.labelPrice1.Size = new System.Drawing.Size(49, 16);
            this.labelPrice1.TabIndex = 8;
            this.labelPrice1.Text = "Цена:";
            // 
            // labelProcessor1
            // 
            this.labelProcessor1.AutoSize = true;
            this.labelProcessor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcessor1.ForeColor = System.Drawing.Color.Blue;
            this.labelProcessor1.Location = new System.Drawing.Point(19, 254);
            this.labelProcessor1.Name = "labelProcessor1";
            this.labelProcessor1.Size = new System.Drawing.Size(93, 16);
            this.labelProcessor1.TabIndex = 7;
            this.labelProcessor1.Text = "Процессор:";
            // 
            // labelOS1
            // 
            this.labelOS1.AutoSize = true;
            this.labelOS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOS1.ForeColor = System.Drawing.Color.Blue;
            this.labelOS1.Location = new System.Drawing.Point(19, 224);
            this.labelOS1.Name = "labelOS1";
            this.labelOS1.Size = new System.Drawing.Size(33, 16);
            this.labelOS1.TabIndex = 6;
            this.labelOS1.Text = "ОС:";
            // 
            // labelModel1
            // 
            this.labelModel1.AutoSize = true;
            this.labelModel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel1.ForeColor = System.Drawing.Color.Blue;
            this.labelModel1.Location = new System.Drawing.Point(19, 194);
            this.labelModel1.Name = "labelModel1";
            this.labelModel1.Size = new System.Drawing.Size(68, 16);
            this.labelModel1.TabIndex = 5;
            this.labelModel1.Text = "Модель:";
            // 
            // tbPrice1
            // 
            this.tbPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPrice1.Location = new System.Drawing.Point(189, 278);
            this.tbPrice1.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice1.Name = "tbPrice1";
            this.tbPrice1.Size = new System.Drawing.Size(182, 22);
            this.tbPrice1.TabIndex = 4;
            // 
            // tbProcessor1
            // 
            this.tbProcessor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProcessor1.Location = new System.Drawing.Point(189, 248);
            this.tbProcessor1.Margin = new System.Windows.Forms.Padding(4);
            this.tbProcessor1.Name = "tbProcessor1";
            this.tbProcessor1.Size = new System.Drawing.Size(182, 22);
            this.tbProcessor1.TabIndex = 3;
            // 
            // tbOS1
            // 
            this.tbOS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOS1.Location = new System.Drawing.Point(189, 218);
            this.tbOS1.Margin = new System.Windows.Forms.Padding(4);
            this.tbOS1.Name = "tbOS1";
            this.tbOS1.Size = new System.Drawing.Size(182, 22);
            this.tbOS1.TabIndex = 2;
            // 
            // tbModel1
            // 
            this.tbModel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModel1.Location = new System.Drawing.Point(189, 188);
            this.tbModel1.Margin = new System.Windows.Forms.Padding(4);
            this.tbModel1.Name = "tbModel1";
            this.tbModel1.Size = new System.Drawing.Size(182, 22);
            this.tbModel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkedListBoxOptions);
            this.tabPage2.Controls.Add(this.labelPrice2);
            this.tabPage2.Controls.Add(this.labelProcessor2);
            this.tabPage2.Controls.Add(this.labelOS2);
            this.tabPage2.Controls.Add(this.labelModel2);
            this.tabPage2.Controls.Add(this.tbPrice2);
            this.tabPage2.Controls.Add(this.tbProcessor2);
            this.tabPage2.Controls.Add(this.tbOS2);
            this.tabPage2.Controls.Add(this.tbModel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(391, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактирование информации";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeletePhone
            // 
            this.btnDeletePhone.Location = new System.Drawing.Point(17, 375);
            this.btnDeletePhone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePhone.Name = "btnDeletePhone";
            this.btnDeletePhone.Size = new System.Drawing.Size(113, 44);
            this.btnDeletePhone.TabIndex = 3;
            this.btnDeletePhone.Text = "Удалить текущую";
            this.btnDeletePhone.UseVisualStyleBackColor = true;
            this.btnDeletePhone.Click += new System.EventHandler(this.btnDeletePhone_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(149, 375);
            this.btnClearList.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(113, 44);
            this.btnClearList.TabIndex = 4;
            this.btnClearList.Text = "Очистить список";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.ForeColor = System.Drawing.Color.Blue;
            this.btnSaveToFile.Location = new System.Drawing.Point(17, 451);
            this.btnSaveToFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(113, 44);
            this.btnSaveToFile.TabIndex = 5;
            this.btnSaveToFile.Text = "Сохранить в файл";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.ForeColor = System.Drawing.Color.Blue;
            this.btnReadFromFile.Location = new System.Drawing.Point(149, 451);
            this.btnReadFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(113, 44);
            this.btnReadFromFile.TabIndex = 6;
            this.btnReadFromFile.Text = "Прочитать из файла";
            this.btnReadFromFile.UseVisualStyleBackColor = true;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // labelPrice2
            // 
            this.labelPrice2.AutoSize = true;
            this.labelPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice2.ForeColor = System.Drawing.Color.Red;
            this.labelPrice2.Location = new System.Drawing.Point(19, 117);
            this.labelPrice2.Name = "labelPrice2";
            this.labelPrice2.Size = new System.Drawing.Size(49, 16);
            this.labelPrice2.TabIndex = 16;
            this.labelPrice2.Text = "Цена:";
            // 
            // labelProcessor2
            // 
            this.labelProcessor2.AutoSize = true;
            this.labelProcessor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcessor2.ForeColor = System.Drawing.Color.Blue;
            this.labelProcessor2.Location = new System.Drawing.Point(19, 87);
            this.labelProcessor2.Name = "labelProcessor2";
            this.labelProcessor2.Size = new System.Drawing.Size(93, 16);
            this.labelProcessor2.TabIndex = 15;
            this.labelProcessor2.Text = "Процессор:";
            // 
            // labelOS2
            // 
            this.labelOS2.AutoSize = true;
            this.labelOS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOS2.ForeColor = System.Drawing.Color.Blue;
            this.labelOS2.Location = new System.Drawing.Point(19, 57);
            this.labelOS2.Name = "labelOS2";
            this.labelOS2.Size = new System.Drawing.Size(33, 16);
            this.labelOS2.TabIndex = 14;
            this.labelOS2.Text = "ОС:";
            // 
            // labelModel2
            // 
            this.labelModel2.AutoSize = true;
            this.labelModel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel2.ForeColor = System.Drawing.Color.Blue;
            this.labelModel2.Location = new System.Drawing.Point(19, 27);
            this.labelModel2.Name = "labelModel2";
            this.labelModel2.Size = new System.Drawing.Size(68, 16);
            this.labelModel2.TabIndex = 13;
            this.labelModel2.Text = "Модель:";
            // 
            // tbPrice2
            // 
            this.tbPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPrice2.Location = new System.Drawing.Point(189, 111);
            this.tbPrice2.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice2.Name = "tbPrice2";
            this.tbPrice2.Size = new System.Drawing.Size(182, 22);
            this.tbPrice2.TabIndex = 12;
            // 
            // tbProcessor2
            // 
            this.tbProcessor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProcessor2.Location = new System.Drawing.Point(189, 81);
            this.tbProcessor2.Margin = new System.Windows.Forms.Padding(4);
            this.tbProcessor2.Name = "tbProcessor2";
            this.tbProcessor2.Size = new System.Drawing.Size(182, 22);
            this.tbProcessor2.TabIndex = 11;
            // 
            // tbOS2
            // 
            this.tbOS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOS2.Location = new System.Drawing.Point(189, 51);
            this.tbOS2.Margin = new System.Windows.Forms.Padding(4);
            this.tbOS2.Name = "tbOS2";
            this.tbOS2.Size = new System.Drawing.Size(182, 22);
            this.tbOS2.TabIndex = 10;
            // 
            // tbModel2
            // 
            this.tbModel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModel2.Location = new System.Drawing.Point(189, 21);
            this.tbModel2.Margin = new System.Windows.Forms.Padding(4);
            this.tbModel2.Name = "tbModel2";
            this.tbModel2.Size = new System.Drawing.Size(182, 22);
            this.tbModel2.TabIndex = 9;
            // 
            // checkedListBoxOptions
            // 
            this.checkedListBoxOptions.FormattingEnabled = true;
            this.checkedListBoxOptions.Location = new System.Drawing.Point(22, 157);
            this.checkedListBoxOptions.Name = "checkedListBoxOptions";
            this.checkedListBoxOptions.Size = new System.Drawing.Size(349, 124);
            this.checkedListBoxOptions.TabIndex = 17;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile STORE";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TextBox tbPrice1;
        private System.Windows.Forms.TextBox tbProcessor1;
        private System.Windows.Forms.TextBox tbOS1;
        private System.Windows.Forms.TextBox tbModel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPrice1;
        private System.Windows.Forms.Label labelProcessor1;
        private System.Windows.Forms.Label labelOS1;
        private System.Windows.Forms.Label labelModel1;
        private System.Windows.Forms.ListBox listBoxOptions;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.CheckedListBox checkedListBoxOptions;
        private System.Windows.Forms.Label labelPrice2;
        private System.Windows.Forms.Label labelProcessor2;
        private System.Windows.Forms.Label labelOS2;
        private System.Windows.Forms.Label labelModel2;
        private System.Windows.Forms.TextBox tbPrice2;
        private System.Windows.Forms.TextBox tbProcessor2;
        private System.Windows.Forms.TextBox tbOS2;
        private System.Windows.Forms.TextBox tbModel2;
    }
}

