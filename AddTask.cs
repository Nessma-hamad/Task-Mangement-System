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
    public partial class AddTask : Form
    {
        string currentteam_name = string.Empty;
        public AddTask(string teamname)
        {
            InitializeComponent();
            currentteam_name = teamname;

        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            
            Team Currentteam = new Team();
            foreach(Team team in SampleData.Teams)
            {
                if(team.Name ==currentteam_name )
                {
                    Currentteam = team;
                }
            }

            foreach(User user in Currentteam.users)
            {
                currentteam_users.Items.Add(user.Name);
                
            }

            foreach (Category category in Currentteam.categories)
            {
                Task_Category.Items.Add(category.Name);

            }

            
            Task_Pirority.Items.Add(Pirority.high);
            Task_Pirority.Items.Add(Pirority.meduim);
            Task_Pirority.Items.Add(Pirority.low);



        }

        private void Create_task_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
