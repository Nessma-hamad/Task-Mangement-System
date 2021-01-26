
namespace Project
{
    partial class Teamform
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
            this.TeamformClose = new System.Windows.Forms.Button();
            this.TeamName = new System.Windows.Forms.Label();
            this.TeamTabs = new System.Windows.Forms.TabControl();
            this.CategoryTab = new System.Windows.Forms.TabPage();
            this.CategoriesPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cName = new System.Windows.Forms.Label();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.openAdditionformCategory = new System.Windows.Forms.Button();
            this.MembersTab = new System.Windows.Forms.TabPage();
            this.MemberTab_panel = new System.Windows.Forms.Panel();
            this.AddMemberBtn = new System.Windows.Forms.Button();
            this.ArchiveTab = new System.Windows.Forms.TabPage();
            this.DescriptionTeam = new System.Windows.Forms.Label();
            this.TeamTabs.SuspendLayout();
            this.CategoryTab.SuspendLayout();
            this.CategoriesPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MembersTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamformClose
            // 
            this.TeamformClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TeamformClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeamformClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamformClose.ForeColor = System.Drawing.Color.White;
            this.TeamformClose.Location = new System.Drawing.Point(847, 2);
            this.TeamformClose.Name = "TeamformClose";
            this.TeamformClose.Size = new System.Drawing.Size(57, 49);
            this.TeamformClose.TabIndex = 0;
            this.TeamformClose.Text = "X";
            this.TeamformClose.UseVisualStyleBackColor = false;
            this.TeamformClose.Click += new System.EventHandler(this.TeamformClose_Click);
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName.Location = new System.Drawing.Point(28, 29);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(170, 33);
            this.TeamName.TabIndex = 1;
            this.TeamName.Text = "TeamName";
            // 
            // TeamTabs
            // 
            this.TeamTabs.Controls.Add(this.CategoryTab);
            this.TeamTabs.Controls.Add(this.MembersTab);
            this.TeamTabs.Controls.Add(this.ArchiveTab);
            this.TeamTabs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTabs.Location = new System.Drawing.Point(13, 115);
            this.TeamTabs.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TeamTabs.Multiline = true;
            this.TeamTabs.Name = "TeamTabs";
            this.TeamTabs.Padding = new System.Drawing.Point(20, 20);
            this.TeamTabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TeamTabs.SelectedIndex = 0;
            this.TeamTabs.Size = new System.Drawing.Size(880, 440);
            this.TeamTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TeamTabs.TabIndex = 2;
            // 
            // CategoryTab
            // 
            this.CategoryTab.Controls.Add(this.CategoriesPanel);
            this.CategoryTab.Controls.Add(this.AddTaskBtn);
            this.CategoryTab.Controls.Add(this.openAdditionformCategory);
            this.CategoryTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTab.Location = new System.Drawing.Point(4, 64);
            this.CategoryTab.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.CategoryTab.Name = "CategoryTab";
            this.CategoryTab.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.CategoryTab.Size = new System.Drawing.Size(872, 372);
            this.CategoryTab.TabIndex = 0;
            this.CategoryTab.Text = "Categories";
            this.CategoryTab.UseVisualStyleBackColor = true;
            // 
            // CategoriesPanel
            // 
            this.CategoriesPanel.AutoScroll = true;
            this.CategoriesPanel.ContextMenuStrip = this.contextMenuStrip1;
            this.CategoriesPanel.Controls.Add(this.listBox1);
            this.CategoriesPanel.Controls.Add(this.panel2);
            this.CategoriesPanel.Controls.Add(this.categoryList);
            this.CategoriesPanel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesPanel.Location = new System.Drawing.Point(17, 14);
            this.CategoriesPanel.Name = "CategoriesPanel";
            this.CategoriesPanel.Size = new System.Drawing.Size(840, 287);
            this.CategoriesPanel.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.showToolStripMenuItem.Text = "show";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(583, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 184);
            this.listBox1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.cName);
            this.panel2.Location = new System.Drawing.Point(583, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 49);
            this.panel2.TabIndex = 1;
            // 
            // cName
            // 
            this.cName.AutoSize = true;
            this.cName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cName.ForeColor = System.Drawing.Color.White;
            this.cName.Location = new System.Drawing.Point(38, 8);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(74, 24);
            this.cName.TabIndex = 0;
            this.cName.Text = "label1";
            // 
            // categoryList
            // 
            this.categoryList.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(65, 35);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(206, 32);
            this.categoryList.TabIndex = 0;
            this.categoryList.Text = "Categories List";
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.AddTaskBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddTaskBtn.FlatAppearance.BorderSize = 0;
            this.AddTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTaskBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskBtn.ForeColor = System.Drawing.Color.White;
            this.AddTaskBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTaskBtn.Location = new System.Drawing.Point(17, 307);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(171, 52);
            this.AddTaskBtn.TabIndex = 1;
            this.AddTaskBtn.Text = "Add Task";
            this.AddTaskBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddTaskBtn.UseVisualStyleBackColor = false;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // openAdditionformCategory
            // 
            this.openAdditionformCategory.BackColor = System.Drawing.Color.Teal;
            this.openAdditionformCategory.FlatAppearance.BorderSize = 0;
            this.openAdditionformCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openAdditionformCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAdditionformCategory.ForeColor = System.Drawing.Color.White;
            this.openAdditionformCategory.Location = new System.Drawing.Point(686, 307);
            this.openAdditionformCategory.Name = "openAdditionformCategory";
            this.openAdditionformCategory.Size = new System.Drawing.Size(171, 52);
            this.openAdditionformCategory.TabIndex = 0;
            this.openAdditionformCategory.Text = "Add Category";
            this.openAdditionformCategory.UseVisualStyleBackColor = false;
            this.openAdditionformCategory.Click += new System.EventHandler(this.openAdditionformCategory_Click);
            // 
            // MembersTab
            // 
            this.MembersTab.Controls.Add(this.MemberTab_panel);
            this.MembersTab.Controls.Add(this.AddMemberBtn);
            this.MembersTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembersTab.Location = new System.Drawing.Point(4, 64);
            this.MembersTab.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.MembersTab.Name = "MembersTab";
            this.MembersTab.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.MembersTab.Size = new System.Drawing.Size(872, 372);
            this.MembersTab.TabIndex = 1;
            this.MembersTab.Text = "Members";
            this.MembersTab.UseVisualStyleBackColor = true;
            this.MembersTab.Click += new System.EventHandler(this.MembersTab_Click);
            // 
            // MemberTab_panel
            // 
            this.MemberTab_panel.Location = new System.Drawing.Point(7, 14);
            this.MemberTab_panel.Name = "MemberTab_panel";
            this.MemberTab_panel.Size = new System.Drawing.Size(859, 299);
            this.MemberTab_panel.TabIndex = 1;
            // 
            // AddMemberBtn
            // 
            this.AddMemberBtn.AutoEllipsis = true;
            this.AddMemberBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberBtn.ForeColor = System.Drawing.Color.White;
            this.AddMemberBtn.Location = new System.Drawing.Point(685, 319);
            this.AddMemberBtn.Name = "AddMemberBtn";
            this.AddMemberBtn.Size = new System.Drawing.Size(181, 47);
            this.AddMemberBtn.TabIndex = 0;
            this.AddMemberBtn.Text = "Invite Member";
            this.AddMemberBtn.UseVisualStyleBackColor = false;
            this.AddMemberBtn.Click += new System.EventHandler(this.AddMemberBtn_Click);
            // 
            // ArchiveTab
            // 
            this.ArchiveTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchiveTab.Location = new System.Drawing.Point(4, 64);
            this.ArchiveTab.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.ArchiveTab.Name = "ArchiveTab";
            this.ArchiveTab.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ArchiveTab.Size = new System.Drawing.Size(872, 372);
            this.ArchiveTab.TabIndex = 2;
            this.ArchiveTab.Text = "Archive";
            this.ArchiveTab.UseVisualStyleBackColor = true;
            // 
            // DescriptionTeam
            // 
            this.DescriptionTeam.AutoSize = true;
            this.DescriptionTeam.Location = new System.Drawing.Point(137, 80);
            this.DescriptionTeam.Name = "DescriptionTeam";
            this.DescriptionTeam.Size = new System.Drawing.Size(51, 20);
            this.DescriptionTeam.TabIndex = 3;
            this.DescriptionTeam.Text = "label1";
            // 
            // Teamform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 570);
            this.ControlBox = false;
            this.Controls.Add(this.DescriptionTeam);
            this.Controls.Add(this.TeamTabs);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.TeamformClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Teamform";
            this.Load += new System.EventHandler(this.Teamform_Load);
            this.TeamTabs.ResumeLayout(false);
            this.CategoryTab.ResumeLayout(false);
            this.CategoriesPanel.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MembersTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TeamformClose;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.TabControl TeamTabs;
        private System.Windows.Forms.TabPage CategoryTab;
        private System.Windows.Forms.Button AddTaskBtn;
        private System.Windows.Forms.Button openAdditionformCategory;
        private System.Windows.Forms.TabPage MembersTab;
        private System.Windows.Forms.Button AddMemberBtn;
        private System.Windows.Forms.TabPage ArchiveTab;
        private System.Windows.Forms.Panel CategoriesPanel;
        private System.Windows.Forms.Panel MemberTab_panel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ComboBox categoryList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label cName;
        private System.Windows.Forms.Label DescriptionTeam;
    }
}

