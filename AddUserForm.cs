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
    public partial class AddUserForm : Form
    {
        public static event Action<string, string> newuser;
        public AddUserForm()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "PNG images|*.png|JPG files|*.jpg";
            op.Title = "Open Image file";

            if (op.ShowDialog() == DialogResult.OK)
            {
                User_Pic.Image = Image.FromFile(op.FileName);
            }

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool vaild = true;


            lblEmailValidation.Visible = false;


            if (txtboxName.Text.Length >= 4)
            {
                lblNameVaildation.Visible = false;

            }
            else
            {
                lblNameVaildation.Visible = true;
                vaild = false;
            }


            if (txtboxEmail.Text.Contains("@") && txtboxEmail.Text.Contains("."))
            {
                lblEmailValidation.Visible = false;

            }
            else
            {
                lblEmailValidation.Visible = true;
                vaild = false;

            }

            if (vaild == true)
            {

                MessageBox.Show("sucess added user");
                User AddNewUser = new User(txtboxName.Text, txtboxEmail.Text);
                newuser(AddNewUser.Name, AddNewUser.Email);
                Controls.Clear();
                InitializeComponent();
                this.Hide();

            }



        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void txtboxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
