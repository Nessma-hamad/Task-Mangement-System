﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Category
    {
        public string Name { get; set; }
        public List<Task> Tasks=new List<Task>();
        public Category(String name)
        {
            Name = name;
            //ddddd
            //sssssss
            //eeeeeee
            
        }
        public override string ToString()
        {
            return $"Ctegory Name : {Name}";
        }
    }
}
