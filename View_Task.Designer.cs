namespace Project
{
    partial class View_Task
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
            this.T_Name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.T_ctaegory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.T_dateline = new System.Windows.Forms.Label();
            this.T_Done = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddComment = new System.Windows.Forms.Button();
            this.writecomment = new System.Windows.Forms.TextBox();
            this.T_comments = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.T_users = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.T_attachments = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.T_Pirority = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // T_Name
            // 
            this.T_Name.AutoSize = true;
            this.T_Name.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Name.Location = new System.Drawing.Point(313, 29);
            this.T_Name.Name = "T_Name";
            this.T_Name.Size = new System.Drawing.Size(124, 21);
            this.T_Name.TabIndex = 1;
            this.T_Name.Text = "Task NAme";
            this.T_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category :";
            // 
            // T_ctaegory
            // 
            this.T_ctaegory.AutoSize = true;
            this.T_ctaegory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_ctaegory.Location = new System.Drawing.Point(178, 96);
            this.T_ctaegory.Name = "T_ctaegory";
            this.T_ctaegory.Size = new System.Drawing.Size(132, 19);
            this.T_ctaegory.TabIndex = 9;
            this.T_ctaegory.Text = "Task Category ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "DateLine :";
            // 
            // T_dateline
            // 
            this.T_dateline.AutoSize = true;
            this.T_dateline.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_dateline.Location = new System.Drawing.Point(178, 142);
            this.T_dateline.Name = "T_dateline";
            this.T_dateline.Size = new System.Drawing.Size(122, 19);
            this.T_dateline.TabIndex = 11;
            this.T_dateline.Text = "Task Dateline";
            // 
            // T_Done
            // 
            this.T_Done.AutoSize = true;
            this.T_Done.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Done.Location = new System.Drawing.Point(56, 230);
            this.T_Done.Name = "T_Done";
            this.T_Done.Size = new System.Drawing.Size(78, 27);
            this.T_Done.TabIndex = 16;
            this.T_Done.Text = "Done";
            this.T_Done.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddComment);
            this.groupBox1.Controls.Add(this.writecomment);
            this.groupBox1.Controls.Add(this.T_comments);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 491);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 201);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Comments ";
            // 
            // AddComment
            // 
            this.AddComment.Location = new System.Drawing.Point(617, 82);
            this.AddComment.Name = "AddComment";
            this.AddComment.Size = new System.Drawing.Size(30, 30);
            this.AddComment.TabIndex = 22;
            this.AddComment.Text = "+";
            this.AddComment.UseVisualStyleBackColor = true;
            this.AddComment.Click += new System.EventHandler(this.AddComment_Click);
            // 
            // writecomment
            // 
            this.writecomment.Location = new System.Drawing.Point(327, 85);
            this.writecomment.Name = "writecomment";
            this.writecomment.Size = new System.Drawing.Size(271, 27);
            this.writecomment.TabIndex = 21;
            // 
            // T_comments
            // 
            this.T_comments.FormattingEnabled = true;
            this.T_comments.ItemHeight = 19;
            this.T_comments.Location = new System.Drawing.Point(17, 37);
            this.T_comments.Name = "T_comments";
            this.T_comments.Size = new System.Drawing.Size(271, 137);
            this.T_comments.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.T_users);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 210);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assigned Users";
            // 
            // T_users
            // 
            this.T_users.FormattingEnabled = true;
            this.T_users.ItemHeight = 19;
            this.T_users.Location = new System.Drawing.Point(17, 39);
            this.T_users.Name = "T_users";
            this.T_users.Size = new System.Drawing.Size(271, 137);
            this.T_users.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.T_attachments);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(404, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 210);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Task Attachments  :";
            // 
            // T_attachments
            // 
            this.T_attachments.FormattingEnabled = true;
            this.T_attachments.ItemHeight = 19;
            this.T_attachments.Location = new System.Drawing.Point(23, 39);
            this.T_attachments.Name = "T_attachments";
            this.T_attachments.Size = new System.Drawing.Size(177, 137);
            this.T_attachments.TabIndex = 15;
            this.T_attachments.SelectedIndexChanged += new System.EventHandler(this.T_attachments_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(703, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // T_Pirority
            // 
            this.T_Pirority.AutoSize = true;
            this.T_Pirority.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Pirority.Location = new System.Drawing.Point(178, 189);
            this.T_Pirority.Name = "T_Pirority";
            this.T_Pirority.Size = new System.Drawing.Size(122, 19);
            this.T_Pirority.TabIndex = 24;
            this.T_Pirority.Text = "Task Dateline";
            this.T_Pirority.Click += new System.EventHandler(this.T_Pirority_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pirority :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(215, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "+Attachment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // View_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 729);
            this.Controls.Add(this.T_Pirority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.T_Done);
            this.Controls.Add(this.T_dateline);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.T_ctaegory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.T_Name);
            this.Name = "View_Task";
            this.Text = "View_Task";
            this.Load += new System.EventHandler(this.View_Task_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label T_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label T_ctaegory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label T_dateline;
        private System.Windows.Forms.CheckBox T_Done;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddComment;
        private System.Windows.Forms.TextBox writecomment;
        private System.Windows.Forms.ListBox T_comments;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox T_users;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox T_attachments;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label T_Pirority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}