using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddUserForm : Form
    {
        string iName;
        public static event Action<string, string> newuser;

        public AddUserForm()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog op = new OpenFileDialog();
            //op.Filter = "PNG images|*.png|JPG files|*.jpg";
            //op.Title = "Open Image file";

            //if (op.ShowDialog() == DialogResult.OK)
            //{
            //    User_Pic.Image = Image.FromFile(op.FileName);
            //    string userimagePath = op.FileName;
            //}
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\images\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iName = opFile.SafeFileName;   // <---
                    string filepath = opFile.FileName;    // <---
                    File.Copy(filepath, appPath + iName); // <---
                    User_Pic.Image = new Bitmap(opFile.OpenFile());
                    // pictureBox2.Image = Image.FromFile(filepath);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
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
                User AddNewUser = new User(txtboxName.Text, txtboxEmail.Text, iName);


                SampleData.Users.Add(AddNewUser);


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
