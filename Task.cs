﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public enum Pirority
    {
        low,
        meduim,
        high
    }
    class Task
    {
        public string Name { get; set; }
        //sssssssdddddd
         
        public DateTime DateLine { get; set; }
        public string Attachments { get; set; }
        public bool IsDone { get; set; }
        public Pirority pirority { get; set; }

        public List<User> Team_Users = new List<User>();
        public Category Task_Catergory ;

        public List<Comment> Comments= new List<Comment>();
        public Task()
        {
           
        }
        public Task(string CategoryName)
        {
            Task_Catergory = new Category(CategoryName);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
