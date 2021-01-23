using System;
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
        //ddddddd
        public DateTime DateLine { get; set; }
        public string Attachments { get; set; }
        public bool IsDone { get; set; }
        public Pirority pirority { get; set; }

        public List<Comment> Comments= new List<Comment>();
       public Task()
        {
            
        }
        public override string ToString()
        {
            return $"Name : {Name} \t isDone :{IsDone} \t DateLine : {DateLine} \t pirority :{pirority}";
        }
    }
}
