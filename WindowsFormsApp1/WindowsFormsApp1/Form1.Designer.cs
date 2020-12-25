namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStaffMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMemberToolStripMenuItem,
            this.newStaffMemberToolStripMenuItem,
            this.searchMemberToolStripMenuItem,
            this.deleteMemberToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newMemberToolStripMenuItem
            // 
            this.newMemberToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.newMemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newMemberToolStripMenuItem.Image")));
            this.newMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            this.newMemberToolStripMenuItem.Size = new System.Drawing.Size(141, 54);
            this.newMemberToolStripMenuItem.Text = "New Member";
            this.newMemberToolStripMenuItem.Click += new System.EventHandler(this.newMemberToolStripMenuItem_Click);
            // 
            // newStaffMemberToolStripMenuItem
            // 
            this.newStaffMemberToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.newStaffMemberToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.newStaffMemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newStaffMemberToolStripMenuItem.Image")));
            this.newStaffMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newStaffMemberToolStripMenuItem.Name = "newStaffMemberToolStripMenuItem";
            this.newStaffMemberToolStripMenuItem.Size = new System.Drawing.Size(168, 54);
            this.newStaffMemberToolStripMenuItem.Text = "New Staff Memebr";
            this.newStaffMemberToolStripMenuItem.Click += new System.EventHandler(this.newStaffMemberToolStripMenuItem_Click);
            // 
            // searchMemberToolStripMenuItem
            // 
            this.searchMemberToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.searchMemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchMemberToolStripMenuItem.Image")));
            this.searchMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchMemberToolStripMenuItem.Name = "searchMemberToolStripMenuItem";
            this.searchMemberToolStripMenuItem.Size = new System.Drawing.Size(152, 54);
            this.searchMemberToolStripMenuItem.Text = "Search Member";
            this.searchMemberToolStripMenuItem.Click += new System.EventHandler(this.searchMemberToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.deleteMemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteMemberToolStripMenuItem.Image")));
            this.deleteMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(150, 54);
            this.deleteMemberToolStripMenuItem.Text = "Delete Member";
            this.deleteMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(110, 54);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(62, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 550);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStaffMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

