using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class CategoryForm : Form
    {
        public static event Action<string> newCtegory;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int count = 0;
        private void circleButton1_Click(object sender, EventArgs e)
        {
           if(newCtegory !=null && CatgoryNameInput.Text !="")
            {
                count++;
                MessageBox.Show(count.ToString());
                newCtegory(CatgoryNameInput.Text);
            }
            else
            {
                MessageBox.Show("category name empty!!please enter category name first");
            }
        }
    }
}
