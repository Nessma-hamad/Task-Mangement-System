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
    public delegate void AddUserTo_Team();
    public partial class Invite_Member : Form
    {
        public static event AddUserTo_Team MyEvent;
        List<User> Users = SampleData.Users;
        string currentteam_name = string.Empty;
        static Team GetCurrentTeam(string name)
        {
            Team Currentteam = new Team();
            foreach (Team team in SampleData.Teams)
            {
                if (team.Name == name)
                {
                    Currentteam = team;
                }
            }
            return Currentteam;

        }
        public Invite_Member(string teamname)
        {
            InitializeComponent();
            currentteam_name = teamname;
        }

        private void Invite_Member_Load(object sender, EventArgs e)
        {
            foreach (User user in Users)
            {
                selectusers.Items.Add(user.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Team Currentteam = GetCurrentTeam(currentteam_name);
            foreach(string username in selectusers.SelectedItems)
            {
                foreach (User user in Users)
                {
                    if(user.Name==username)
                    {
                        Currentteam.users.Add(user);
                        if (MyEvent != null)
                            MyEvent();
                    }

                }

               

            }
            this.Close();
        }
    }
}
