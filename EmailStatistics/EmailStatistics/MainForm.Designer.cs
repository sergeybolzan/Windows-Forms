﻿namespace EmailStatistics
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Мама");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Папа");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Близкие родственники", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Дядя");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Тетя");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Дальние родственники", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Родственники", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Отдела");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Фирмы");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Сотрудники", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Лучшие друзья");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Друзья по команде");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Друзья", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Получатели", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode24,
            treeNode27});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuAddUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnAddToSchedule = new System.Windows.Forms.Button();
            this.tbMessageText = new System.Windows.Forms.TextBox();
            this.labelMessageText = new System.Windows.Forms.Label();
            this.tbTheme = new System.Windows.Forms.TextBox();
            this.labelTheme = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.tbEmails = new System.Windows.Forms.TextBox();
            this.tbNames = new System.Windows.Forms.TextBox();
            this.labelEmails = new System.Windows.Forms.Label();
            this.labelNames = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxIsEnabledSSL = new System.Windows.Forms.CheckBox();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUserAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbServerAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSaveServerSMTPSettings = new System.Windows.Forms.Button();
            this.contextMenuAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuAddUser
            // 
            this.contextMenuAddUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiAddUser});
            this.contextMenuAddUser.Name = "contextMenuAddUser";
            this.contextMenuAddUser.Size = new System.Drawing.Size(127, 26);
            // 
            // cmiAddUser
            // 
            this.cmiAddUser.Name = "cmiAddUser";
            this.cmiAddUser.Size = new System.Drawing.Size(126, 22);
            this.cmiAddUser.Text = "Добавить";
            this.cmiAddUser.Click += new System.EventHandler(this.cmiAddUser_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(910, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 639);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(910, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(910, 615);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 2;
            // 
            // tvMain
            // 
            this.tvMain.CheckBoxes = true;
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvMain.ImageIndex = 5;
            this.tvMain.ImageList = this.imageList;
            this.tvMain.Location = new System.Drawing.Point(0, 0);
            this.tvMain.Name = "tvMain";
            treeNode15.Name = "Node0";
            treeNode15.Tag = "bolira@inbox.ru";
            treeNode15.Text = "Мама";
            treeNode16.Name = "Node1";
            treeNode16.Tag = "hoaxi@mail.ru";
            treeNode16.Text = "Папа";
            treeNode17.ContextMenuStrip = this.contextMenuAddUser;
            treeNode17.ImageKey = "2.png";
            treeNode17.Name = "Node4";
            treeNode17.SelectedImageKey = "2.png";
            treeNode17.Text = "Близкие родственники";
            treeNode18.Name = "Node0";
            treeNode18.Tag = "uncle@mail.ru";
            treeNode18.Text = "Дядя";
            treeNode19.Name = "Node1";
            treeNode19.Tag = "aunt@mail.ru";
            treeNode19.Text = "Тетя";
            treeNode20.ContextMenuStrip = this.contextMenuAddUser;
            treeNode20.ImageKey = "2.png";
            treeNode20.Name = "Node5";
            treeNode20.SelectedImageKey = "2.png";
            treeNode20.Text = "Дальние родственники";
            treeNode21.ImageKey = "2.png";
            treeNode21.Name = "Node1";
            treeNode21.SelectedImageKey = "2.png";
            treeNode21.Text = "Родственники";
            treeNode22.ContextMenuStrip = this.contextMenuAddUser;
            treeNode22.ImageKey = "1.png";
            treeNode22.Name = "Node6";
            treeNode22.SelectedImageKey = "1.png";
            treeNode22.Text = "Отдела";
            treeNode23.ContextMenuStrip = this.contextMenuAddUser;
            treeNode23.ImageKey = "1.png";
            treeNode23.Name = "Node7";
            treeNode23.SelectedImageKey = "1.png";
            treeNode23.Text = "Фирмы";
            treeNode24.ImageKey = "1.png";
            treeNode24.Name = "Node2";
            treeNode24.SelectedImageKey = "1.png";
            treeNode24.Text = "Сотрудники";
            treeNode25.ContextMenuStrip = this.contextMenuAddUser;
            treeNode25.ImageKey = "5.png";
            treeNode25.Name = "Node8";
            treeNode25.SelectedImageKey = "5.png";
            treeNode25.Text = "Лучшие друзья";
            treeNode26.ContextMenuStrip = this.contextMenuAddUser;
            treeNode26.ImageKey = "5.png";
            treeNode26.Name = "Node9";
            treeNode26.SelectedImageKey = "5.png";
            treeNode26.Text = "Друзья по команде";
            treeNode27.ImageKey = "5.png";
            treeNode27.Name = "Node3";
            treeNode27.SelectedImageKey = "5.png";
            treeNode27.Text = "Друзья";
            treeNode28.ImageKey = "6.png";
            treeNode28.Name = "Node0";
            treeNode28.SelectedImageKey = "6.png";
            treeNode28.Text = "Получатели";
            this.tvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode28});
            this.tvMain.SelectedImageIndex = 5;
            this.tvMain.Size = new System.Drawing.Size(369, 615);
            this.tvMain.TabIndex = 0;
            this.tvMain.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvMain_AfterCheck);
            this.tvMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvMain_MouseDown);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "1.png");
            this.imageList.Images.SetKeyName(1, "2.png");
            this.imageList.Images.SetKeyName(2, "3.png");
            this.imageList.Images.SetKeyName(3, "4.png");
            this.imageList.Images.SetKeyName(4, "5.png");
            this.imageList.Images.SetKeyName(5, "6.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 615);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteFile);
            this.tabPage1.Controls.Add(this.tbFileName);
            this.tabPage1.Controls.Add(this.btnAddFile);
            this.tabPage1.Controls.Add(this.btnAddToSchedule);
            this.tabPage1.Controls.Add(this.tbMessageText);
            this.tabPage1.Controls.Add(this.labelMessageText);
            this.tabPage1.Controls.Add(this.tbTheme);
            this.tabPage1.Controls.Add(this.labelTheme);
            this.tabPage1.Controls.Add(this.dateTimePicker);
            this.tabPage1.Controls.Add(this.labelTime);
            this.tabPage1.Controls.Add(this.monthCalendar);
            this.tabPage1.Controls.Add(this.tbEmails);
            this.tabPage1.Controls.Add(this.tbNames);
            this.tabPage1.Controls.Add(this.labelEmails);
            this.tabPage1.Controls.Add(this.labelNames);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основной";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteFile.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDeleteFile.Location = new System.Drawing.Point(24, 539);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(136, 25);
            this.btnDeleteFile.TabIndex = 15;
            this.btnDeleteFile.Text = "Удалить файл";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFileName.Location = new System.Drawing.Point(175, 509);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(333, 22);
            this.tbFileName.TabIndex = 14;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddFile.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnAddFile.Location = new System.Drawing.Point(24, 508);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(136, 25);
            this.btnAddFile.TabIndex = 13;
            this.btnAddFile.Text = "Добавить файл";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnAddToSchedule
            // 
            this.btnAddToSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToSchedule.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnAddToSchedule.Location = new System.Drawing.Point(304, 545);
            this.btnAddToSchedule.Name = "btnAddToSchedule";
            this.btnAddToSchedule.Size = new System.Drawing.Size(204, 38);
            this.btnAddToSchedule.TabIndex = 12;
            this.btnAddToSchedule.Text = "Добавить в расписание";
            this.btnAddToSchedule.UseVisualStyleBackColor = true;
            this.btnAddToSchedule.Click += new System.EventHandler(this.btnAddToSchedule_Click);
            // 
            // tbMessageText
            // 
            this.tbMessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMessageText.Location = new System.Drawing.Point(24, 405);
            this.tbMessageText.Multiline = true;
            this.tbMessageText.Name = "tbMessageText";
            this.tbMessageText.Size = new System.Drawing.Size(484, 84);
            this.tbMessageText.TabIndex = 10;
            // 
            // labelMessageText
            // 
            this.labelMessageText.AutoSize = true;
            this.labelMessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessageText.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelMessageText.Location = new System.Drawing.Point(21, 386);
            this.labelMessageText.Name = "labelMessageText";
            this.labelMessageText.Size = new System.Drawing.Size(139, 16);
            this.labelMessageText.TabIndex = 9;
            this.labelMessageText.Text = "Текст сообщения:";
            // 
            // tbTheme
            // 
            this.tbTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTheme.Location = new System.Drawing.Point(214, 293);
            this.tbTheme.Multiline = true;
            this.tbTheme.Name = "tbTheme";
            this.tbTheme.Size = new System.Drawing.Size(294, 84);
            this.tbTheme.TabIndex = 8;
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTheme.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelTheme.Location = new System.Drawing.Point(211, 274);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(134, 16);
            this.labelTheme.TabIndex = 7;
            this.labelTheme.Text = "Тема сообщения:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "HH\'ч\' : mm\'м\'";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(214, 234);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(111, 26);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.Value = new System.DateTime(2017, 3, 31, 0, 0, 0, 0);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelTime.Location = new System.Drawing.Point(211, 215);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(159, 16);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Время отправления:";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(24, 215);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 4;
            // 
            // tbEmails
            // 
            this.tbEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmails.Location = new System.Drawing.Point(93, 115);
            this.tbEmails.Multiline = true;
            this.tbEmails.Name = "tbEmails";
            this.tbEmails.Size = new System.Drawing.Size(415, 79);
            this.tbEmails.TabIndex = 3;
            // 
            // tbNames
            // 
            this.tbNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNames.Location = new System.Drawing.Point(93, 15);
            this.tbNames.Multiline = true;
            this.tbNames.Name = "tbNames";
            this.tbNames.Size = new System.Drawing.Size(415, 79);
            this.tbNames.TabIndex = 2;
            // 
            // labelEmails
            // 
            this.labelEmails.AutoSize = true;
            this.labelEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmails.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelEmails.Location = new System.Drawing.Point(21, 118);
            this.labelEmails.Name = "labelEmails";
            this.labelEmails.Size = new System.Drawing.Size(66, 16);
            this.labelEmails.TabIndex = 1;
            this.labelEmails.Text = "Адреса:";
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNames.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelNames.Location = new System.Drawing.Point(21, 18);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(49, 16);
            this.labelNames.TabIndex = 0;
            this.labelNames.Text = "Кому:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Результаты рассылки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(396, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSaveServerSMTPSettings);
            this.tabPage3.Controls.Add(this.tbServerPort);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.checkBoxIsEnabledSSL);
            this.tabPage3.Controls.Add(this.tbUserPassword);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbUserAccount);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.tbServerAddress);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.comboBoxServer);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(529, 589);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Настройки сервера SMTP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbServerPort
            // 
            this.tbServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServerPort.Location = new System.Drawing.Point(333, 54);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.ReadOnly = true;
            this.tbServerPort.Size = new System.Drawing.Size(168, 22);
            this.tbServerPort.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(52, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Включен SSL";
            // 
            // checkBoxIsEnabledSSL
            // 
            this.checkBoxIsEnabledSSL.AutoSize = true;
            this.checkBoxIsEnabledSSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIsEnabledSSL.Location = new System.Drawing.Point(22, 101);
            this.checkBoxIsEnabledSSL.Name = "checkBoxIsEnabledSSL";
            this.checkBoxIsEnabledSSL.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsEnabledSSL.TabIndex = 11;
            this.checkBoxIsEnabledSSL.UseVisualStyleBackColor = true;
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserPassword.Location = new System.Drawing.Point(100, 189);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.PasswordChar = '*';
            this.tbUserPassword.Size = new System.Drawing.Size(401, 22);
            this.tbUserPassword.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(19, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "пароль";
            // 
            // tbUserAccount
            // 
            this.tbUserAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserAccount.Location = new System.Drawing.Point(100, 149);
            this.tbUserAccount.Name = "tbUserAccount";
            this.tbUserAccount.Size = new System.Drawing.Size(401, 22);
            this.tbUserAccount.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(19, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "аккаунт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(284, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "порт";
            // 
            // tbServerAddress
            // 
            this.tbServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServerAddress.Location = new System.Drawing.Point(100, 54);
            this.tbServerAddress.Name = "tbServerAddress";
            this.tbServerAddress.ReadOnly = true;
            this.tbServerAddress.Size = new System.Drawing.Size(168, 22);
            this.tbServerAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "адрес";
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Location = new System.Drawing.Point(100, 17);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(168, 24);
            this.comboBoxServer.TabIndex = 2;
            this.comboBoxServer.SelectedIndexChanged += new System.EventHandler(this.comboBoxServer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Сервер";
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnSaveServerSMTPSettings
            // 
            this.btnSaveServerSMTPSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveServerSMTPSettings.Location = new System.Drawing.Point(355, 268);
            this.btnSaveServerSMTPSettings.Name = "btnSaveServerSMTPSettings";
            this.btnSaveServerSMTPSettings.Size = new System.Drawing.Size(146, 36);
            this.btnSaveServerSMTPSettings.TabIndex = 14;
            this.btnSaveServerSMTPSettings.Text = "Сохранить";
            this.btnSaveServerSMTPSettings.UseVisualStyleBackColor = true;
            this.btnSaveServerSMTPSettings.Click += new System.EventHandler(this.btnSaveServerSMTPSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 661);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика Email";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuAddUser.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip contextMenuAddUser;
        private System.Windows.Forms.ToolStripMenuItem cmiAddUser;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.TextBox tbNames;
        private System.Windows.Forms.Label labelEmails;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.TextBox tbEmails;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnAddToSchedule;
        private System.Windows.Forms.TextBox tbMessageText;
        private System.Windows.Forms.Label labelMessageText;
        private System.Windows.Forms.TextBox tbTheme;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxIsEnabledSSL;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUserAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbServerAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.Button btnSaveServerSMTPSettings;
    }
}

