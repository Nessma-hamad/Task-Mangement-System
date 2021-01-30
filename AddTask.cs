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
        bool created = false;
        string currentteam_name = string.Empty;
        string task_name = string.Empty;

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
        public AddTask(string teamname, string taskname)
        {
            InitializeComponent();
            currentteam_name = teamname;
            task_name = taskname;


        }
        public AddTask(string teamname)
        {
            InitializeComponent();
            currentteam_name = teamname;
            


        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            Team Currentteam = GetCurrentTeam(currentteam_name);

            Task Currenttask = null;
            foreach (Category category in Currentteam.categories)
            {
                Task_Category.Items.Add(category.Name);

            }


            Task_Pirority.Items.Add(Pirority.high);
            Task_Pirority.Items.Add(Pirority.meduim);
            Task_Pirority.Items.Add(Pirority.low);

           
            foreach (Task task in Currentteam.TeamTasks)
            {
                if (task.Name == task_name)
                {
                    Currenttask = task;
                }
            }
            if(Currenttask!=null)
            {
                foreach (User user in Currenttask.Team_Users)
                {
                    currentteam_users.Items.Add(user.Name);

                }

                Task_Category.SelectedItem=Currenttask.Task_Catergory.Name.ToString();
                Task_Pirority.SelectedItem=Currenttask.pirority;
                Task_Name.Text = task_name;
                Task_Dateline.Value = Currenttask.DateLine;
                created = true;
               

            }
            else if(Currenttask==null)
            {
                foreach (User user in Currentteam.users)
                {
                    currentteam_users.Items.Add(user.Name);

                }


            }



        }

        private void Create_task_Click(object sender, EventArgs e)
        {

           
            Team Currentteam = GetCurrentTeam(currentteam_name);
            if(created==true)
            {
                Task Currenttask = null;
                
                foreach (Task task in Currentteam.TeamTasks)
                {
                    if (task.Name == task_name)
                    {
                        Currenttask = task;
                        task.Name = Task_Name.Text;
                        task.DateLine = Task_Dateline.Value;
                        task.pirority = (Pirority)Task_Pirority.SelectedItem;
                        task.Task_Catergory.Name= Task_Category.SelectedItem.ToString();



                        foreach (string username in currentteam_users.SelectedItems)
                        {
                            foreach (User user in Currentteam.users)
                            {
                                if (user.Name == username)
                                {
                                    task.Team_Users.Add(user);
                                }

                            }
                        }

                    }
                }
                View_Task view = new View_Task(Currentteam.Name, Currenttask.Name);
                view.Show();
                Close();



            }
            else
            {
                String TaskCategory = Task_Category.SelectedItem.ToString();
                Task NewTask = new Task(TaskCategory);

                NewTask.Name = Task_Name.Text;
                NewTask.DateLine = Task_Dateline.Value;
                NewTask.pirority = (Pirority)Task_Pirority.SelectedItem;



                foreach (string username in currentteam_users.SelectedItems)
                {
                    foreach (User user in Currentteam.users)
                    {
                        if (user.Name == username)
                        {
                            NewTask.Team_Users.Add(user);
                        }

                    }



                }


                Currentteam.TeamTasks.Add(NewTask);
                foreach (Category category in Currentteam.categories)
                {
                    if (category.Name == TaskCategory)
                    {
                        category.Tasks.Add(NewTask);
                    }
                }
            }
            
            //if(TaskCategory==string.Empty)
            //{
            //    MessageBox.Show("Please select Catergory ..");
            //}
            //if (Task_Name.Text == string.Empty)
            //{
            //    MessageBox.Show("Please Enter Task Name ..");
            //}
            //if (Task_Dateline.Value == null)
            //{
            //    MessageBox.Show("Please Set A Dateline for Your Task ..");
            //}
            //if (Task_Pirority.SelectedItem == null)
            //{
            //    MessageBox.Show("Please Set A Pirority for Your Task ..");
            //}

            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
