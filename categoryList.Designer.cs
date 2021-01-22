
namespace Project
{
    partial class categoryList
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
            this.CategoryListPanel = new System.Windows.Forms.Panel();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.TaskListPanel = new System.Windows.Forms.Panel();
            this.CategoryListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryListPanel
            // 
            this.CategoryListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CategoryListPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.CategoryListPanel.Controls.Add(this.CategoryNameLabel);
            this.CategoryListPanel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryListPanel.ForeColor = System.Drawing.Color.White;
            this.CategoryListPanel.Location = new System.Drawing.Point(0, 3);
            this.CategoryListPanel.Name = "CategoryListPanel";
            this.CategoryListPanel.Size = new System.Drawing.Size(100, 42);
            this.CategoryListPanel.TabIndex = 0;
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Location = new System.Drawing.Point(36, 23);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(0, 22);
            this.CategoryNameLabel.TabIndex = 0;
            // 
            // TaskListPanel
            // 
            this.TaskListPanel.Location = new System.Drawing.Point(3, 51);
            this.TaskListPanel.Name = "TaskListPanel";
            this.TaskListPanel.Size = new System.Drawing.Size(166, 133);
            this.TaskListPanel.TabIndex = 1;
            // 
            // categoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TaskListPanel);
            this.Controls.Add(this.CategoryListPanel);
            this.Name = "categoryList";
            this.Size = new System.Drawing.Size(100, 185);
            this.CategoryListPanel.ResumeLayout(false);
            this.CategoryListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CategoryListPanel;
        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.Panel TaskListPanel;
    }
}
