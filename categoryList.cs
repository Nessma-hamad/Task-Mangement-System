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
    public partial class categoryList : UserControl
    {
        public string categeoryName
        {
            get { return CategoryNameLabel.Text;}
            set { CategoryNameLabel.Text = value;}
        }
        public categoryList(string s)
        {
            InitializeComponent();
            categeoryName = s;
        }
    }
}
