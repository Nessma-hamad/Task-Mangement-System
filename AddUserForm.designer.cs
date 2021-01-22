namespace Project
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.User_Pic = new System.Windows.Forms.PictureBox();
            this.AddUserbtn = new System.Windows.Forms.Button();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.pic_label = new System.Windows.Forms.Label();
            this.Email_label = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.User_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // User_Pic
            // 
            this.User_Pic.Image = ((System.Drawing.Image)(resources.GetObject("User_Pic.Image")));
            this.User_Pic.Location = new System.Drawing.Point(245, 173);
            this.User_Pic.Name = "User_Pic";
            this.User_Pic.Size = new System.Drawing.Size(246, 97);
            this.User_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User_Pic.TabIndex = 13;
            this.User_Pic.TabStop = false;
            this.User_Pic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddUserbtn
            // 
            this.AddUserbtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserbtn.Location = new System.Drawing.Point(508, 305);
            this.AddUserbtn.Name = "AddUserbtn";
            this.AddUserbtn.Size = new System.Drawing.Size(155, 60);
            this.AddUserbtn.TabIndex = 12;
            this.AddUserbtn.Text = "AddUser";
            this.AddUserbtn.UseVisualStyleBackColor = true;
            this.AddUserbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmail.Location = new System.Drawing.Point(245, 107);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(256, 40);
            this.txtboxEmail.TabIndex = 11;
            this.txtboxEmail.TextChanged += new System.EventHandler(this.txtboxEmail_TextChanged);
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxName.Location = new System.Drawing.Point(245, 29);
            this.txtboxName.Multiline = true;
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(256, 41);
            this.txtboxName.TabIndex = 10;
            // 
            // pic_label
            // 
            this.pic_label.AutoSize = true;
            this.pic_label.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pic_label.Location = new System.Drawing.Point(30, 197);
            this.pic_label.Name = "pic_label";
            this.pic_label.Size = new System.Drawing.Size(163, 33);
            this.pic_label.TabIndex = 9;
            this.pic_label.Text = "AddPicture";
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_label.Location = new System.Drawing.Point(53, 107);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(100, 33);
            this.Email_label.TabIndex = 8;
            this.Email_label.Text = "Email:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(30, 32);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(164, 33);
            this.UserNameLabel.TabIndex = 7;
            this.UserNameLabel.Text = " UserName";
            this.UserNameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 377);
            this.Controls.Add(this.User_Pic);
            this.Controls.Add(this.AddUserbtn);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.pic_label);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.UserNameLabel);
            this.Name = "AddUserForm";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox User_Pic;
        private System.Windows.Forms.Button AddUserbtn;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label pic_label;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label UserNameLabel;
    }
}