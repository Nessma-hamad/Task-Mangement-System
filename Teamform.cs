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
        private Team checkExistingTeam(string name)
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
        private Team GetCurrentTeam(String Teamname)
        {
            Team t = checkExistingTeam(Teamname);
            if (string.IsNullOrEmpty(t.Name))
            {
                SampleData.Teams.Add(new Team(Teamname));
                t= checkExistingTeam(Teamname);
            }
            return t;

        }

        public Teamform(string TName)
        {
            InitializeComponent();
            TeamName.Text = TName;
            CategoryForm.newCtegory += AddCategory;
            
        }
        private void FillCategoryList()
        {
            Team current = GetCurrentTeam(TeamName.Text);
                    foreach (Category i in current.categories)
                    {
                        categoryList.DataSource = null;
                        categoryList.DisplayMember = nameof(i.Name);
                        categoryList.DataSource = current.categories;
                    }
               

        }
        private void fillListOfTask(IEnumerable<Task> Tasks)
        {
            checkedListBox_Tasks.Items.Clear();
            foreach (Task task in Tasks)
            {
                checkedListBox_Tasks.Items.Add(task.Name);
            }
        }
        private void DisplayTeamUsers()
        {
            int y = 0;
            Team team = GetCurrentTeam(TeamName.Text);
            foreach (User u in team.users)
            {
                MemberTab_panel.Controls.Add(new TeamUser() { UserName = u.Name, Email = u.Email, Location = new Point(0, y)});
                y += 70;
            }
        }
        private void AddDoneTakToArchive()
        {

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
            Team Currentteam = GetCurrentTeam(TeamName.Text);
            Currentteam.categories.Add(new Category(name));
            categoryList.DataSource = null;
            foreach (Category c in Currentteam.categories)
            {
                categoryList.DisplayMember = nameof(c.Name);
                categoryList.DataSource = Currentteam.categories;
            }
        }

        private void Teamform_Load(object sender, EventArgs e)
        {
            FillCategoryList();
            DisplayTeamUsers();
        }
        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryList.SelectedIndex == -1)
            {
                cName.Text = string.Empty;
                return;
            }
            Category category = (Category)categoryList.SelectedItem;
            cName.Text = categoryList.SelectedItem.ToString();
            fillListOfTask(category.Tasks);
        }

        private void MembersTab_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }
    }
}
