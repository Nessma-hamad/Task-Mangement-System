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
    public partial class Teamform : Form
    {
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
        public Teamform(string TName)
        {
            InitializeComponent();
            TeamName.Text = TName;
            CategoryForm.newCtegory += AddCategory;
            
        }
        private void fillListOfTask(IEnumerable<Task> Tasks)
        {
            listBox1.Items.Clear();
            foreach (Task task in Tasks)
            {
                listBox1.Items.Add(task.Name);
            }
        }
        private void TeamformClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openAdditionformCategory_Click(object sender, EventArgs e)
        {
            CategoryForm cf = new CategoryForm();
            cf.Show();
        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            AddTask addtask = new AddTask(TeamName.Text);
            addtask.Show();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            Invite_Member invite = new Invite_Member();
            invite.Show();
        }
        public void AddCategory(string name)
        {
            Team t = new Team(this.TeamName.Text, this.DescriptionTeam.Text);
            t.categories.Add(new Category(name));
            this.categoryList.Items.Add(name);
        }

        private void Teamform_Load(object sender, EventArgs e)
        {
            foreach (var item in SampleData.Teams)
            {
                if (item.Name == TeamName.Text)
                {
                    foreach (Category i in item.categories)
                    {
                        /*categoryList.DataSource = null;
                        categoryList.DisplayMember = nameof(i.Name);//"Name";
                        categoryList.ValueMember = "category";  //"ID";
                        categoryList.DataSource = item.categories;*/
                        categoryList.Items.Add(i.Name);
                    }
                }

            }
        }
        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryList.SelectedIndex == -1)
            {
                cName.Text = string.Empty;
                return;
            }
            cName.Text = categoryList.SelectedItem.ToString();
            /* Category category = (Category)categoryList.SelectedItem;
             fillListOfTask(category.Tasks);*/
        }
    }
}
