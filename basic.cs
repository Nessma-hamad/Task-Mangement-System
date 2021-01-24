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
        public basic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int loc = 20;
            foreach (var item in SampleData.Teams)
            {
                Button btn = new Button() { Text = item.Name, Location = new Point(loc, 50), Size = new Size(100, 100) };
                btn.Click += new EventHandler(ShowTeam);
                this.Team_Tab.Controls.Add(btn);
                loc += 100;
            }
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
    }
}
