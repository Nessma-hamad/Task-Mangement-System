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
    public partial class createTeamForm : Form
    {
        public static event Action<string, string> NewTeam;
        public createTeamForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Team_Load(object sender, EventArgs e)
        {

        }

        private void description_label_Click(object sender, EventArgs e)
        {

        }

        private void Addteambtn_Click(object sender, EventArgs e)
        {
            Team Add_team = new Team(NameTeam_txtbox.Text, desc_txtbox.Text);
            NewTeam(Add_team.Name, Add_team.Description);
            //Controls.Clear();
            //InitializeComponent();
            this.Hide();
            Teamform teamform = new Teamform(this.NameTeam_txtbox.Text);
            teamform.Show();
        }
    }
}
