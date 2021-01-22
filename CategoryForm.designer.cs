
namespace Project
{
    partial class CategoryForm
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
            this.CategoryFormClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CatgoryNameInput = new System.Windows.Forms.TextBox();
            this.circleButton1 = new Project.circleButton();
            this.AddToCategoryBtn = new Project.circleButton();
            this.SuspendLayout();
            // 
            // CategoryFormClose
            // 
            this.CategoryFormClose.BackColor = System.Drawing.Color.Red;
            this.CategoryFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryFormClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryFormClose.ForeColor = System.Drawing.Color.White;
            this.CategoryFormClose.Location = new System.Drawing.Point(354, 12);
            this.CategoryFormClose.Name = "CategoryFormClose";
            this.CategoryFormClose.Size = new System.Drawing.Size(42, 42);
            this.CategoryFormClose.TabIndex = 0;
            this.CategoryFormClose.Text = "X";
            this.CategoryFormClose.UseVisualStyleBackColor = false;
            this.CategoryFormClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name:";
            // 
            // CatgoryNameInput
            // 
            this.CatgoryNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatgoryNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatgoryNameInput.Location = new System.Drawing.Point(156, 119);
            this.CatgoryNameInput.Name = "CatgoryNameInput";
            this.CatgoryNameInput.Size = new System.Drawing.Size(225, 24);
            this.CatgoryNameInput.TabIndex = 2;
            // 
            // circleButton1
            // 
            this.circleButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleButton1.ForeColor = System.Drawing.Color.White;
            this.circleButton1.Location = new System.Drawing.Point(306, 182);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(59, 60);
            this.circleButton1.TabIndex = 3;
            this.circleButton1.Text = "+";
            this.circleButton1.UseVisualStyleBackColor = false;
            this.circleButton1.Click += new System.EventHandler(this.circleButton1_Click);
            // 
            // AddToCategoryBtn
            // 
            this.AddToCategoryBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.AddToCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToCategoryBtn.Font = new System.Drawing.Font("Bell MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.AddToCategoryBtn.Location = new System.Drawing.Point(178, 188);
            this.AddToCategoryBtn.Name = "AddToCategoryBtn";
            this.AddToCategoryBtn.Size = new System.Drawing.Size(69, 67);
            this.AddToCategoryBtn.TabIndex = 3;
            this.AddToCategoryBtn.Text = "+";
            this.AddToCategoryBtn.UseVisualStyleBackColor = false;
            // 
            // CategoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 252);
            this.ControlBox = false;
            this.Controls.Add(this.circleButton1);
            this.Controls.Add(this.CatgoryNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryFormClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CategoryFormClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CatgoryNameInput;
        private circleButton AddToCategoryBtn;
        private circleButton circleButton1;
    }
}