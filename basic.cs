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
    public partial class basic : Form
    {
        List<Team> listOfTeams = new List<Team>();
        public basic()
        {
            InitializeComponent();
            AddUserForm.newuser += adduser;
            createTeamForm.NewTeam += addteam;
        }

        private void addteam(string teamName, string teamDesciption)
        {
            listOfTeams.Add(new Team(teamName, teamDesciption));
            int width = 120;
            int height = 100;

            foreach (Team team in listOfTeams)
            {
                Button dynamicTeamBtn = new Button();
                dynamicTeamBtn.Location = new Point(width, height);
                dynamicTeamBtn.Text = team.Name;
                dynamicTeamBtn.Font = new Font("Georgia", 16);
                dynamicTeamBtn.Click += new EventHandler(ShowTeam);
                dynamicTeamBtn.Size = new Size(150, 70);
                Team_Tab.Controls.Add(dynamicTeamBtn);
                width += 160;
                //loc2 += 50;
                label1.Text = "you have " + listOfTeams.Count.ToString() + " Teams";
            }

        }



        private void adduser(string nameOFuser, string emailofuser)
        {
            ListViewItem items = lvData.Items.Add(nameOFuser);
            items.SubItems.Add(emailofuser);
            int numberOfUser = lvData.Items.Count;
            noOfUser.Text = "No Of Users " + numberOfUser.ToString();
            lvData.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int loc = 20;
            //foreach (var item in SampleData.Teams)
            //{
            //    Button btn = new Button() { Text = item.Name, Location = new Point(loc, 50), Size = new Size(100, 100) };
            //    btn.Click += new EventHandler(ShowTeam);
            //    this.Team_Tab.Controls.Add(btn);
            //    loc += 100;
            //}

        }
        public void ShowTeam(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Teamform teamform = new Teamform(btn.Text);
            teamform.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createTeamForm createteam = new createTeamForm();
            createteam.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddUserForm adduser = new AddUserForm();
            adduser.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Users_tab_Click(object sender, EventArgs e)
        {

        }
    }
}
