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
            this.lblNameVaildation = new System.Windows.Forms.Label();
            this.lblEmailValidation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.User_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // User_Pic
            // 
            this.User_Pic.Image = ((System.Drawing.Image)(resources.GetObject("User_Pic.Image")));
            this.User_Pic.Location = new System.Drawing.Point(275, 229);
            this.User_Pic.Name = "User_Pic";
            this.User_Pic.Size = new System.Drawing.Size(246, 97);
            this.User_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User_Pic.TabIndex = 13;
            this.User_Pic.TabStop = false;
            this.User_Pic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddUserbtn
            // 
            this.AddUserbtn.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserbtn.Location = new System.Drawing.Point(626, 402);
            this.AddUserbtn.Name = "AddUserbtn";
            this.AddUserbtn.Size = new System.Drawing.Size(192, 60);
            this.AddUserbtn.TabIndex = 12;
            this.AddUserbtn.Text = "AddUser";
            this.AddUserbtn.UseVisualStyleBackColor = true;
            this.AddUserbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmail.Location = new System.Drawing.Point(245, 121);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(424, 33);
            this.txtboxEmail.TabIndex = 11;
            this.txtboxEmail.TextChanged += new System.EventHandler(this.txtboxEmail_TextChanged);
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxName.Location = new System.Drawing.Point(245, 29);
            this.txtboxName.Multiline = true;
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(434, 41);
            this.txtboxName.TabIndex = 10;
            // 
            // pic_label
            // 
            this.pic_label.AutoSize = true;
            this.pic_label.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pic_label.Location = new System.Drawing.Point(42, 271);
            this.pic_label.Name = "pic_label";
            this.pic_label.Size = new System.Drawing.Size(156, 24);
            this.pic_label.TabIndex = 9;
            this.pic_label.Text = "AddPicture :";
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_label.Location = new System.Drawing.Point(107, 126);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(89, 24);
            this.Email_label.TabIndex = 8;
            this.Email_label.Text = "Email :";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(53, 34);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(145, 24);
            this.UserNameLabel.TabIndex = 7;
            this.UserNameLabel.Text = " UserName :";
            this.UserNameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNameVaildation
            // 
            this.lblNameVaildation.AutoSize = true;
            this.lblNameVaildation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameVaildation.ForeColor = System.Drawing.Color.Red;
            this.lblNameVaildation.Location = new System.Drawing.Point(240, 84);
            this.lblNameVaildation.Name = "lblNameVaildation";
            this.lblNameVaildation.Size = new System.Drawing.Size(314, 23);
            this.lblNameVaildation.TabIndex = 14;
            this.lblNameVaildation.Text = "Name must Contain at least 4 letters";
            this.lblNameVaildation.Visible = false;
            // 
            // lblEmailValidation
            // 
            this.lblEmailValidation.AutoSize = true;
            this.lblEmailValidation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValidation.ForeColor = System.Drawing.Color.Red;
            this.lblEmailValidation.Location = new System.Drawing.Point(325, 176);
            this.lblEmailValidation.Name = "lblEmailValidation";
            this.lblEmailValidation.Size = new System.Drawing.Size(117, 23);
            this.lblEmailValidation.TabIndex = 15;
            this.lblEmailValidation.Text = "Invaild Email";
            this.lblEmailValidation.Visible = false;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 510);
            this.Controls.Add(this.lblEmailValidation);
            this.Controls.Add(this.lblNameVaildation);
            this.Controls.Add(this.User_Pic);
            this.Controls.Add(this.AddUserbtn);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.pic_label);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.UserNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblNameVaildation;
        private System.Windows.Forms.Label lblEmailValidation;
    }
}