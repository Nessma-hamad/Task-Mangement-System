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
        public Image userPicture
        {
            get
            {
                return UserImage.Image;
            }
            set
            {
                UserImage.Image = value;
            }
        }

        private void RmoveTeamUserBtn_Click(object sender, EventArgs e)
        {
            RemoveUser(this, e);
        }
    }
}
