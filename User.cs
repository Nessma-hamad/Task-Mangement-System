using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class User
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string Picture { set; get; }
        public User() { }
        public User(int id, string name, string email, string password, string picture)
        {
            ID = id;
            Name = name;
            Email = email;
            Password = password;
            Picture = picture;
        }
        public User(int id, string name, string email, string password)
        {
            ID = id;
            Name = name;
            Email = email;
            Password = password;
            Picture = "default photo";
        }
        public void GetUserDetails()
        {
            Console.WriteLine($"userId: {ID} , userName : {Name}, userEmail : {Email} ");

        }
        /*main */
        /* User user1 = new User()
            {
                 ID = 1,
                Name = "safaa",
                Password = "11111",
                Email = "safa",
               Picture = "ssss"
            };
            User user2 = new User()
            {
                ID = 2,
                Name = "nessma",
                Password = "11111",
                Email = "safa",
                Picture = "ssss"
            };
            User user3 = new User()
            {
                ID = 3,
                Name = "Eman",
                Password = "11111",
                Email = "safa",
                Picture = "ssss"
            };
            List<User> Users = new List<User>();
            Users.Add(user1);
            Users.Add(user2);
            Users.Add(user3);
            foreach(User u in Users)
            {
               // Console.WriteLine("ID= {0},Name={1},Email={2}", u.ID, u.Name, u.Email);
                u.GetUserDetails();
            }
            


            Console.ReadKey();*/


    }
}
