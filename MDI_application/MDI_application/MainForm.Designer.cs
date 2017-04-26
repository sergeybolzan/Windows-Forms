namespace MDI_application
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSwitchList = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddSwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddModel = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddVLAN_manag = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.miHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.miVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSwitchList,
            this.miAddSwitch,
            this.miAddAddress,
            this.miAddModel,
            this.miAddVLAN_manag});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.taskToolStripMenuItem.Text = "Задачи";
            // 
            // miSwitchList
            // 
            this.miSwitchList.Name = "miSwitchList";
            this.miSwitchList.Size = new System.Drawing.Size(198, 22);
            this.miSwitchList.Text = "Список коммутаторов";
            this.miSwitchList.Click += new System.EventHandler(this.miSwitches_Click);
            // 
            // miAddSwitch
            // 
            this.miAddSwitch.Name = "miAddSwitch";
            this.miAddSwitch.Size = new System.Drawing.Size(198, 22);
            this.miAddSwitch.Text = "Добавить коммутатор";
            this.miAddSwitch.Click += new System.EventHandler(this.miAddSwitch_Click);
            // 
            // miAddAddress
            // 
            this.miAddAddress.Name = "miAddAddress";
            this.miAddAddress.Size = new System.Drawing.Size(198, 22);
            this.miAddAddress.Text = "Добавить адрес";
            this.miAddAddress.Click += new System.EventHandler(this.miAddAddress_Click);
            // 
            // miAddModel
            // 
            this.miAddModel.Name = "miAddModel";
            this.miAddModel.Size = new System.Drawing.Size(198, 22);
            this.miAddModel.Text = "Добавить модель";
            this.miAddModel.Click += new System.EventHandler(this.miAddModel_Click);
            // 
            // miAddVLAN_manag
            // 
            this.miAddVLAN_manag.Name = "miAddVLAN_manag";
            this.miAddVLAN_manag.Size = new System.Drawing.Size(198, 22);
            this.miAddVLAN_manag.Text = "Добавить VLAN";
            this.miAddVLAN_manag.Click += new System.EventHandler(this.miAddVLAN_manag_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCascade,
            this.miHorizontal,
            this.miVertical,
            this.toolStripMenuItem1,
            this.minimizeToolStripMenuItem,
            this.maximizeToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.windowToolStripMenuItem.Text = "Окно";
            // 
            // miCascade
            // 
            this.miCascade.Name = "miCascade";
            this.miCascade.Size = new System.Drawing.Size(175, 22);
            this.miCascade.Text = "Каскадом";
            this.miCascade.Click += new System.EventHandler(this.miCascade_Click);
            // 
            // miHorizontal
            // 
            this.miHorizontal.Name = "miHorizontal";
            this.miHorizontal.Size = new System.Drawing.Size(175, 22);
            this.miHorizontal.Text = "Горизонтально";
            this.miHorizontal.Click += new System.EventHandler(this.miHorizontal_Click);
            // 
            // miVertical
            // 
            this.miVertical.Name = "miVertical";
            this.miVertical.Size = new System.Drawing.Size(175, 22);
            this.miVertical.Text = "Вертикально";
            this.miVertical.Click += new System.EventHandler(this.miVertical_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.minimizeToolStripMenuItem.Text = "Минимизировать";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.maximizeToolStripMenuItem.Text = "Максимизировать";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 673);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switches";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAddSwitch;
        private System.Windows.Forms.ToolStripMenuItem miSwitchList;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAddAddress;
        private System.Windows.Forms.ToolStripMenuItem miCascade;
        private System.Windows.Forms.ToolStripMenuItem miHorizontal;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAddModel;
        private System.Windows.Forms.ToolStripMenuItem miAddVLAN_manag;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miVertical;
    }
}

