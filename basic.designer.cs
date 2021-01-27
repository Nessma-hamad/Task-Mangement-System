namespace Project
{
    partial class basic
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Team_Tab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_NewTeam = new System.Windows.Forms.Button();
            this.Users_tab = new System.Windows.Forms.TabPage();
            this.ADD_Users = new System.Windows.Forms.Button();
            this.noOfUser = new System.Windows.Forms.Label();
            this.lvData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabControl.SuspendLayout();
            this.Team_Tab.SuspendLayout();
            this.Users_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Team_Tab);
            this.TabControl.Controls.Add(this.Users_tab);
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabControl.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.ItemSize = new System.Drawing.Size(2000, 75);
            this.TabControl.Location = new System.Drawing.Point(-2, -1);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(40, 15);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.ShowToolTips = true;
            this.TabControl.Size = new System.Drawing.Size(885, 540);
            this.TabControl.TabIndex = 0;
            // 
            // Team_Tab
            // 
            this.Team_Tab.Controls.Add(this.label1);
            this.Team_Tab.Controls.Add(this.Add_NewTeam);
            this.Team_Tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Team_Tab.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team_Tab.Location = new System.Drawing.Point(4, 79);
            this.Team_Tab.Name = "Team_Tab";
            this.Team_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Team_Tab.Size = new System.Drawing.Size(877, 457);
            this.Team_Tab.TabIndex = 0;
            this.Team_Tab.Text = "Teams";
            this.Team_Tab.UseVisualStyleBackColor = true;
            this.Team_Tab.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teams";
            // 
            // Add_NewTeam
            // 
            this.Add_NewTeam.Location = new System.Drawing.Point(564, 374);
            this.Add_NewTeam.Name = "Add_NewTeam";
            this.Add_NewTeam.Size = new System.Drawing.Size(290, 67);
            this.Add_NewTeam.TabIndex = 0;
            this.Add_NewTeam.Text = "+ New Team";
            this.Add_NewTeam.UseVisualStyleBackColor = true;
            this.Add_NewTeam.Click += new System.EventHandler(this.button1_Click);
            // 
            // Users_tab
            // 
            this.Users_tab.AutoScroll = true;
            this.Users_tab.Controls.Add(this.lvData);
            this.Users_tab.Controls.Add(this.noOfUser);
            this.Users_tab.Controls.Add(this.ADD_Users);
            this.Users_tab.Location = new System.Drawing.Point(4, 79);
            this.Users_tab.Name = "Users_tab";
            this.Users_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Users_tab.Size = new System.Drawing.Size(877, 457);
            this.Users_tab.TabIndex = 1;
            this.Users_tab.Text = "Users";
            this.Users_tab.UseVisualStyleBackColor = true;
            // 
            // ADD_Users
            // 
            this.ADD_Users.Location = new System.Drawing.Point(610, 367);
            this.ADD_Users.Name = "ADD_Users";
            this.ADD_Users.Size = new System.Drawing.Size(261, 74);
            this.ADD_Users.TabIndex = 0;
            this.ADD_Users.Text = "Add Users";
            this.ADD_Users.UseVisualStyleBackColor = true;
            this.ADD_Users.Click += new System.EventHandler(this.button2_Click);
            // 
            // noOfUser
            // 
            this.noOfUser.AutoSize = true;
            this.noOfUser.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfUser.Location = new System.Drawing.Point(26, 19);
            this.noOfUser.Name = "noOfUser";
            this.noOfUser.Size = new System.Drawing.Size(422, 35);
            this.noOfUser.TabIndex = 1;
            this.noOfUser.Text = "Click in button to Add Users";
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvData.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvData.Location = new System.Drawing.Point(10, 93);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(560, 348);
            this.lvData.TabIndex = 2;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            this.lvData.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User Name";
            this.columnHeader1.Width = 296;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 237;
            // 
            // basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 531);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "basic";
            this.Text = "Team Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.Team_Tab.ResumeLayout(false);
            this.Team_Tab.PerformLayout();
            this.Users_tab.ResumeLayout(false);
            this.Users_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Team_Tab;
        private System.Windows.Forms.TabPage Users_tab;
        private System.Windows.Forms.Button Add_NewTeam;
        private System.Windows.Forms.Button ADD_Users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label noOfUser;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

