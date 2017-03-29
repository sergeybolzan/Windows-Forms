namespace EmailStatistics
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Мама");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Папа");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Близкие родственники", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Дальние родственники");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Родственники", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Отдела");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Фирмы");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Сотрудники", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Лучшие друзья");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Друзья по команде");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Друзья", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Получатели", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuAddUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelNames = new System.Windows.Forms.Label();
            this.labelEmails = new System.Windows.Forms.Label();
            this.tbNames = new System.Windows.Forms.TextBox();
            this.tbEmails = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.contextMenuAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 562);
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
            this.splitContainer1.Size = new System.Drawing.Size(910, 538);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 2;
            // 
            // tvMain
            // 
            this.tvMain.CheckBoxes = true;
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvMain.ImageIndex = 5;
            this.tvMain.ImageList = this.imageList1;
            this.tvMain.Location = new System.Drawing.Point(0, 0);
            this.tvMain.Name = "tvMain";
            treeNode1.Name = "Node0";
            treeNode1.Tag = "mama@mail.ru";
            treeNode1.Text = "Мама";
            treeNode2.Name = "Node1";
            treeNode2.Tag = "papa@mail.ru";
            treeNode2.Text = "Папа";
            treeNode3.ContextMenuStrip = this.contextMenuAddUser;
            treeNode3.ImageKey = "2.png";
            treeNode3.Name = "Node4";
            treeNode3.SelectedImageKey = "2.png";
            treeNode3.Text = "Близкие родственники";
            treeNode4.ContextMenuStrip = this.contextMenuAddUser;
            treeNode4.ImageKey = "2.png";
            treeNode4.Name = "Node5";
            treeNode4.SelectedImageKey = "2.png";
            treeNode4.Text = "Дальние родственники";
            treeNode5.ImageKey = "2.png";
            treeNode5.Name = "Node1";
            treeNode5.SelectedImageKey = "2.png";
            treeNode5.Text = "Родственники";
            treeNode6.ContextMenuStrip = this.contextMenuAddUser;
            treeNode6.ImageKey = "1.png";
            treeNode6.Name = "Node6";
            treeNode6.SelectedImageKey = "1.png";
            treeNode6.Text = "Отдела";
            treeNode7.ContextMenuStrip = this.contextMenuAddUser;
            treeNode7.ImageKey = "1.png";
            treeNode7.Name = "Node7";
            treeNode7.SelectedImageKey = "1.png";
            treeNode7.Text = "Фирмы";
            treeNode8.ImageKey = "1.png";
            treeNode8.Name = "Node2";
            treeNode8.SelectedImageKey = "1.png";
            treeNode8.Text = "Сотрудники";
            treeNode9.ContextMenuStrip = this.contextMenuAddUser;
            treeNode9.ImageKey = "5.png";
            treeNode9.Name = "Node8";
            treeNode9.SelectedImageKey = "5.png";
            treeNode9.Text = "Лучшие друзья";
            treeNode10.ContextMenuStrip = this.contextMenuAddUser;
            treeNode10.ImageKey = "5.png";
            treeNode10.Name = "Node9";
            treeNode10.SelectedImageKey = "5.png";
            treeNode10.Text = "Друзья по команде";
            treeNode11.ImageKey = "5.png";
            treeNode11.Name = "Node3";
            treeNode11.SelectedImageKey = "5.png";
            treeNode11.Text = "Друзья";
            treeNode12.ImageKey = "6.png";
            treeNode12.Name = "Node0";
            treeNode12.SelectedImageKey = "6.png";
            treeNode12.Text = "Получатели";
            this.tvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.tvMain.SelectedImageIndex = 5;
            this.tvMain.Size = new System.Drawing.Size(369, 538);
            this.tvMain.TabIndex = 0;
            this.tvMain.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvMain_AfterCheck);
            this.tvMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvMain_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            this.imageList1.Images.SetKeyName(5, "6.png");
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
            this.tabControl1.Size = new System.Drawing.Size(537, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Controls.Add(this.tbEmails);
            this.tabPage1.Controls.Add(this.tbNames);
            this.tabPage1.Controls.Add(this.labelEmails);
            this.tabPage1.Controls.Add(this.labelNames);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основной";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Size = new System.Drawing.Size(492, 455);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(492, 455);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Настройки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNames.Location = new System.Drawing.Point(21, 18);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(49, 16);
            this.labelNames.TabIndex = 0;
            this.labelNames.Text = "Кому:";
            // 
            // labelEmails
            // 
            this.labelEmails.AutoSize = true;
            this.labelEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmails.Location = new System.Drawing.Point(21, 118);
            this.labelEmails.Name = "labelEmails";
            this.labelEmails.Size = new System.Drawing.Size(66, 16);
            this.labelEmails.TabIndex = 1;
            this.labelEmails.Text = "Адреса:";
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
            // tbEmails
            // 
            this.tbEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmails.Location = new System.Drawing.Point(93, 115);
            this.tbEmails.Multiline = true;
            this.tbEmails.Name = "tbEmails";
            this.tbEmails.Size = new System.Drawing.Size(415, 79);
            this.tbEmails.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(107, 291);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 584);
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
        private System.Windows.Forms.ImageList imageList1;
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

