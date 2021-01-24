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
        public AddTask(string teamname)
        {
            InitializeComponent();
            currentteam_name = teamname;

        }

        private void AddTask_Load(object sender, EventArgs e)
        {

            Team Currentteam = GetCurrentTeam(currentteam_name);

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
            String TaskCategory =Task_Category.SelectedItem.ToString();

            Task NewTask = new Task(TaskCategory);

            NewTask.Name= Task_Name.Text;
            NewTask.DateLine=Task_Dateline.Value;
            NewTask.pirority = (Pirority)Task_Pirority.SelectedItem;
            
            
           
            foreach(User user in currentteam_users.SelectedItems)
            {
                NewTask.Team_Users.Add(user);

            }

            Team Currentteam = GetCurrentTeam(currentteam_name);
            Currentteam.TeamTasks.Add(NewTask);
            foreach(Category category in Currentteam.categories)
            {
                if(category.Name== TaskCategory)
                {
                    category.Tasks.Add(NewTask);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
