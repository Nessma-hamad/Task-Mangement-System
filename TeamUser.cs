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
    public partial class TeamUser : UserControl
    {
        public static event EventHandler RemoveUser;
        public TeamUser()
        {
            InitializeComponent();
        }
        public string UserName
        {
            get
            {
                return TeamUserName.Text;
            }
            set
            {
                TeamUserName.Text = value;
            }
        }
        public string Email
        {
            get
            {
                return userEmail.Text;
            }
            set
            {
                userEmail.Text = value;
            }
        }
        public string userPicture
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        




        private void RmoveTeamUserBtn_Click(object sender, EventArgs e)
        {
            RemoveUser(this, e);
        }

        private void UserImage_Click_1(object sender, EventArgs e)
        {
            //UserImage.Image = Image.FromFile(@"C:\Users\Microsoft\Pictures\Screenshots\Screenshot(2)");
            //string path = Application.StartupPath;
            //string subfolder = @"\Images\";
            //string imagefilename = trying.Text;
            //UserImage.Image = Image.FromFile(path + subfolder + imagefilename);
            //string path = Application.StartupPath;
            //string subfolder = @"\Images\";
            //string imagefilename = "4c85586e2bb246ef6707e6d810039739.jpg";
            //UserImage.Image = Image.FromFile(path + subfolder + imagefilename);
            string imagefilename = "";
            string path = Application.StartupPath;
            imagefilename = label1.Text;
            string subfolder = @"\Images\";                
            UserImage.Image = Image.FromFile(path + subfolder + imagefilename);
            

            

        }
    }
}
