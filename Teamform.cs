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
        public Teamform()
        {
            InitializeComponent();
            CategoryForm.newCtegory += AddCategory;
            Team t = new Team();
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
            AddTask addtask = new AddTask();
            addtask.Show();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            Invite_Member invite = new Invite_Member();
            invite.Show();
        }
        public void AddCategory(string name)
        {
            
            this.categoryList.Items.Add(name);
        }
    }
}
