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
    public partial class View_Task : Form
    {
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
        public View_Task(string teamname,string taskname)
        {
            InitializeComponent();
            currentteam_name = teamname;
            task_name = taskname;
        }

        private void View_Task_Load(object sender, EventArgs e)
        {
            T_Name.Text = task_name;
            Team Currentteam = GetCurrentTeam(currentteam_name);
            Task Currenttask = new Task();
            foreach(Task task in Currentteam.TeamTasks)
            {
                if(task.Name==task_name)
                {
                    Currenttask = task;
                }
            }
            T_ctaegory.Text = Currenttask.Task_Catergory.Name;
            T_dateline.Text = Currenttask.DateLine.ToString();
            T_Pirority.Text = Currenttask.pirority.ToString();
            if(Currenttask.IsDone==true)
            {
                T_Done.Checked = true;
            }
            foreach(User user in  Currenttask.Team_Users)
            {
                T_users.Items.Add(user.Name);
            }
            foreach (Comment comment in Currenttask.Comments)
            {
                T_comments.Items.Add(comment.CommentContent);
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void T_Pirority_Click(object sender, EventArgs e)
        {

        }

        private void AddComment_Click(object sender, EventArgs e)
        {
            Comment comment = new Comment(writecomment.Text, DateTime.Now);
            Team Currentteam = GetCurrentTeam(currentteam_name);
            Task Currenttask = new Task();
            foreach (Task task in Currentteam.TeamTasks)
            {
                if (task.Name == task_name)
                {
                    Currenttask = task;
                }
            }
            Currenttask.Comments.Add(comment);
            writecomment.Text = "";
            T_comments.Items.Add(comment.CommentContent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTask addtask = new AddTask(task_name);
            addtask.Show();
        }
    }
}
