namespace Project
{
    partial class createTeamForm
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
            this.desc_txtbox = new System.Windows.Forms.TextBox();
            this.NameTeam_txtbox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.NameTeam_label = new System.Windows.Forms.Label();
            this.Addteambtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // desc_txtbox
            // 
            this.desc_txtbox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_txtbox.Location = new System.Drawing.Point(262, 152);
            this.desc_txtbox.Multiline = true;
            this.desc_txtbox.Name = "desc_txtbox";
            this.desc_txtbox.Size = new System.Drawing.Size(274, 100);
            this.desc_txtbox.TabIndex = 15;
            // 
            // NameTeam_txtbox
            // 
            this.NameTeam_txtbox.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTeam_txtbox.Location = new System.Drawing.Point(262, 78);
            this.NameTeam_txtbox.Name = "NameTeam_txtbox";
            this.NameTeam_txtbox.Size = new System.Drawing.Size(274, 40);
            this.NameTeam_txtbox.TabIndex = 14;
            this.NameTeam_txtbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(47, 182);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(169, 33);
            this.description_label.TabIndex = 13;
            this.description_label.Text = "Description";
            this.description_label.Click += new System.EventHandler(this.description_label_Click);
            // 
            // NameTeam_label
            // 
            this.NameTeam_label.AutoSize = true;
            this.NameTeam_label.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTeam_label.Location = new System.Drawing.Point(56, 81);
            this.NameTeam_label.Name = "NameTeam_label";
            this.NameTeam_label.Size = new System.Drawing.Size(94, 33);
            this.NameTeam_label.TabIndex = 12;
            this.NameTeam_label.Text = "Name";
            // 
            // Addteambtn
            // 
            this.Addteambtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addteambtn.Location = new System.Drawing.Point(505, 409);
            this.Addteambtn.Name = "Addteambtn";
            this.Addteambtn.Size = new System.Drawing.Size(165, 53);
            this.Addteambtn.TabIndex = 16;
            this.Addteambtn.Text = "AddTeam";
            this.Addteambtn.UseVisualStyleBackColor = true;
            this.Addteambtn.Click += new System.EventHandler(this.Addteambtn_Click);
            // 
            // createTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 495);
            this.Controls.Add(this.Addteambtn);
            this.Controls.Add(this.desc_txtbox);
            this.Controls.Add(this.NameTeam_txtbox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.NameTeam_label);
            this.Name = "createTeamForm";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Team_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox desc_txtbox;
        private System.Windows.Forms.TextBox NameTeam_txtbox;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label NameTeam_label;
        private System.Windows.Forms.Button Addteambtn;
    }
}