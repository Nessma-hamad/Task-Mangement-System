namespace Project
{
    partial class AddTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Task_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Task_Pirority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Task_Dateline = new System.Windows.Forms.DateTimePicker();
            this.Task_Category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Create_task = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.currentteam_users = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name      :";
            // 
            // Task_Name
            // 
            this.Task_Name.Location = new System.Drawing.Point(145, 93);
            this.Task_Name.Name = "Task_Name";
            this.Task_Name.Size = new System.Drawing.Size(172, 20);
            this.Task_Name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pirority   :";
            // 
            // Task_Pirority
            // 
            this.Task_Pirority.FormattingEnabled = true;
            this.Task_Pirority.Location = new System.Drawing.Point(145, 147);
            this.Task_Pirority.Name = "Task_Pirority";
            this.Task_Pirority.Size = new System.Drawing.Size(172, 21);
            this.Task_Pirority.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "DateLine :";
            // 
            // Task_Dateline
            // 
            this.Task_Dateline.Location = new System.Drawing.Point(145, 209);
            this.Task_Dateline.Name = "Task_Dateline";
            this.Task_Dateline.Size = new System.Drawing.Size(172, 20);
            this.Task_Dateline.TabIndex = 6;
            // 
            // Task_Category
            // 
            this.Task_Category.FormattingEnabled = true;
            this.Task_Category.Location = new System.Drawing.Point(145, 271);
            this.Task_Category.Name = "Task_Category";
            this.Task_Category.Size = new System.Drawing.Size(172, 21);
            this.Task_Category.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Category :";
            // 
            // Create_task
            // 
            this.Create_task.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_task.Location = new System.Drawing.Point(324, 419);
            this.Create_task.Name = "Create_task";
            this.Create_task.Size = new System.Drawing.Size(75, 27);
            this.Create_task.TabIndex = 9;
            this.Create_task.Text = "Create";
            this.Create_task.UseVisualStyleBackColor = true;
            this.Create_task.Click += new System.EventHandler(this.Create_task_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Assign Users  :";
            // 
            // currentteam_users
            // 
            this.currentteam_users.FormattingEnabled = true;
            this.currentteam_users.Location = new System.Drawing.Point(385, 129);
            this.currentteam_users.Name = "currentteam_users";
            this.currentteam_users.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.currentteam_users.Size = new System.Drawing.Size(283, 147);
            this.currentteam_users.TabIndex = 11;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 458);
            this.Controls.Add(this.currentteam_users);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Create_task);
            this.Controls.Add(this.Task_Category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Task_Dateline);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Task_Pirority);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Task_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTask";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Task_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Task_Pirority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Task_Dateline;
        private System.Windows.Forms.ComboBox Task_Category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Create_task;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox currentteam_users;
    }
}

