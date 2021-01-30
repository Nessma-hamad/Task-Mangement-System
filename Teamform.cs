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
            Invite_Member.MyEvent += AddUserToMember;
            TeamUser.RemoveUser += new EventHandler( RemoveUserFromTeam);
            
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
        private void RemoveUserFromTeam(object sender,EventArgs e) {
            Team current = GetCurrentTeam(TeamName.Text);
            TeamUser UC = (TeamUser)sender;
            foreach(User u in current.users.ToList())
            {
                if(u.Name==UC.UserName)
                {
                    current.users.Remove(u);
                }
                MemberTab_panel.Controls.Remove(UC);
                UC.Dispose();

            }
           
        }
        private void fillListOfTask(List<Task> Tasks)
        {
            checkedListBox_Tasks.Items.Clear();
            foreach (Task task in Tasks)
            {
                if(task.IsDone==false)
                checkedListBox_Tasks.Items.Add(task);
                
            }
        }
        private void LoadTo_Archive()
        {
            Team team = GetCurrentTeam(TeamName.Text);
            foreach(Category c in team.categories)
            {
                foreach(Task t in c.Tasks)
                {
                   if(t.IsDone==true)
                    {
                        ListViewItem item = new ListViewItem(t.Name);
                        item.SubItems.Add(t.pirority.ToString());
                        item.SubItems.Add(t.DateLine.ToString());
                        item.SubItems.Add(c.Name);
                        listView1.Items.Add(item);
                    }
                }
            }
        }
        private void DisplayTeamUsers()
        {
            Team team = GetCurrentTeam(TeamName.Text);
            foreach (User user in team.users)
            {
                MemberTab_panel.Controls.Add(new TeamUser() { UserName = user.Name, Email = user.Email,userPicture=user.Picture});
            }
        }
        private void AddUserToMember(User user)
        {
            MemberTab_panel.Controls.Add(new TeamUser() { UserName = user.Name, Email = user.Email, userPicture = user.Picture });
        }
        private void AddDoneTakToArchive(Task task)
        {
            Archive Archive = new Archive() { DoneTasks = new List<Task>() };
            Team current = GetCurrentTeam(TeamName.Text);
            foreach (Category c in current.categories)
            {
                if (c.Name == cName.Text)
                {
                    foreach (Task t in c.Tasks)
                    {
                        if (t.Name == task.Name)
                        {
                            t.IsDone = true;
                            Archive.DoneTasks.Add(t);
                            current.archive = Archive;
                            ListViewItem item = new ListViewItem(task.Name);
                            item.SubItems.Add(t.pirority.ToString());
                            item.SubItems.Add(t.DateLine.ToString());
                            item.SubItems.Add(cName.Text);
                            listView1.Items.Add(item);
                        }
                    }
                }
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
            Invite_Member invite = new Invite_Member(TeamName.Text);
            invite.Show();
        }
       private bool CheckifCategoryExist(string name)
        {
            bool result = false;
            Team t = GetCurrentTeam(TeamName.Text);
            foreach (Category c in t.categories)
            {
                if (c.Name == name)
                    result = true;
            }
            return result;
        }
        public void AddCategory(string name)
        {
              Team Currentteam = GetCurrentTeam(TeamName.Text);
            if(CheckifCategoryExist(name))
            {
                MessageBox.Show("Exist");
            }
            else
            {
                Currentteam.categories.Add(new Category(name));
                categoryList.DataSource = null;
                foreach (Category c in Currentteam.categories)
                {
                    categoryList.DisplayMember = nameof(c.Name);
                    categoryList.DataSource = Currentteam.categories;
                }
            }
                   
        }

        private void Teamform_Load(object sender, EventArgs e)
        {
            FillCategoryList();
            DisplayTeamUsers();
            LoadTo_Archive();
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

       

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Team current = GetCurrentTeam(TeamName.Text);

            if (e.ClickedItem.ToString()== "show")
            {
                View_Task view = new View_Task(current.Name, checkedListBox_Tasks.SelectedItem.ToString());
                view.Show();
            }
            else if (e.ClickedItem.ToString() == "Remove")
            {
                
                foreach (Task task in current.TeamTasks.ToList())
                {
                    
                    if (task.Name==checkedListBox_Tasks.SelectedItem.ToString())
                    {
                        current.TeamTasks.Remove(task);
                    }
                    foreach (Category category in current.categories)
                    {
                        if (cName.Text == category.Name)
                        {

                            foreach (Task ctask in category.Tasks.ToList())
                            {

                                if (ctask.Name == checkedListBox_Tasks.SelectedItem.ToString())
                                {
                                    category.Tasks.Remove(ctask);
                                    checkedListBox_Tasks.Items.Clear();
                                    foreach (Task removedtask in category.Tasks.ToList())
                                    {
                                        if (task.IsDone == false)
                                            checkedListBox_Tasks.Items.Add(task);

                                    }
                                }
                            }
                        }

                    }
                }

                
                

               
            }
        }

        private void checkedListBox_Tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Want Add this Done Task And Archive", "Add To Archive", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (Task itemChecked in checkedListBox_Tasks.CheckedItems.OfType<Task>().ToList())
                {
                    AddDoneTakToArchive(itemChecked);
                    checkedListBox_Tasks.Items.Remove(itemChecked);
                }
            }

        }

        private void checkedListBox_Tasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            
        }
    }
}
