using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SampleData
    {
        public static List<Team> Teams = new List<Team>
        {
            new Team{Name="C#",Description="We design C# project",users=new List<User>
            {
                new User{Name="Eman"},
                new User{Name="Saffa"},
                new User{Name="Nessama"}
            },categories=new List<Category>
            {
                new Category("Design")
                {
                    Tasks=new List<Task>
                    {
                        new Task
                        {
                            Name="login Interface",
                            pirority=Pirority.high,
                            IsDone=false
                        },
                        new Task
                        {
                            Name="signup Interface",
                            pirority=Pirority.meduim,
                            IsDone=false
                        },

                    }
                },
                 new Category("Development")
                {
                    Tasks=new List<Task>
                    {
                        new Task
                        {
                            Name="login",
                            pirority=Pirority.high,
                            IsDone=false
                        },
                        new Task
                        {
                            Name="signup",
                            pirority=Pirority.meduim,
                            IsDone=false
                        },

                    }
                }

            } },
             new Team{Name="SQl",Description="We design SQL project",users=new List<User>
            {
                new User{Name="Eman"},
                new User{Name="Ahmed"},
                new User{Name="Hany"}
            },categories=new List<Category>
            {
                new Category("Design")
                {
                    Tasks=new List<Task>
                    {
                        new Task
                        {
                            Name="Erd Design",
                            pirority=Pirority.high,
                            IsDone=false
                        },
                        new Task
                        {
                            Name="Mapping Design",
                            pirority=Pirority.meduim,
                            IsDone=false
                        },

                    }
                }

            } }
        };
    }
}
