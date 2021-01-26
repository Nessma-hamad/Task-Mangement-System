
namespace Project
{
    partial class TeamUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.RmoveTeamUserBtn = new System.Windows.Forms.Button();
            this.userEmail = new System.Windows.Forms.Label();
            this.TeamUserName = new System.Windows.Forms.Label();
            this.UserImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.RmoveTeamUserBtn);
            this.panel1.Controls.Add(this.userEmail);
            this.panel1.Controls.Add(this.TeamUserName);
            this.panel1.Controls.Add(this.UserImage);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 86);
            this.panel1.TabIndex = 0;
            // 
            // RmoveTeamUserBtn
            // 
            this.RmoveTeamUserBtn.BackColor = System.Drawing.Color.Crimson;
            this.RmoveTeamUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RmoveTeamUserBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RmoveTeamUserBtn.ForeColor = System.Drawing.Color.White;
            this.RmoveTeamUserBtn.Location = new System.Drawing.Point(359, 29);
            this.RmoveTeamUserBtn.Name = "RmoveTeamUserBtn";
            this.RmoveTeamUserBtn.Size = new System.Drawing.Size(96, 35);
            this.RmoveTeamUserBtn.TabIndex = 3;
            this.RmoveTeamUserBtn.Text = "Remove";
            this.RmoveTeamUserBtn.UseVisualStyleBackColor = false;
            // 
            // userEmail
            // 
            this.userEmail.AutoSize = true;
            this.userEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmail.ForeColor = System.Drawing.Color.Gray;
            this.userEmail.Location = new System.Drawing.Point(116, 44);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(45, 20);
            this.userEmail.TabIndex = 2;
            this.userEmail.Text = "email";
            // 
            // TeamUserName
            // 
            this.TeamUserName.AutoSize = true;
            this.TeamUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamUserName.Location = new System.Drawing.Point(106, 23);
            this.TeamUserName.Name = "TeamUserName";
            this.TeamUserName.Size = new System.Drawing.Size(94, 21);
            this.TeamUserName.TabIndex = 1;
            this.TeamUserName.Text = "User Name";
            // 
            // UserImage
            // 
            this.UserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserImage.Location = new System.Drawing.Point(3, 3);
            this.UserImage.Name = "UserImage";
            this.UserImage.Size = new System.Drawing.Size(86, 76);
            this.UserImage.TabIndex = 0;
            this.UserImage.TabStop = false;
            // 
            // TeamUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TeamUser";
            this.Size = new System.Drawing.Size(486, 92);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RmoveTeamUserBtn;
        private System.Windows.Forms.Label userEmail;
        private System.Windows.Forms.Label TeamUserName;
        private System.Windows.Forms.PictureBox UserImage;
    }
}
