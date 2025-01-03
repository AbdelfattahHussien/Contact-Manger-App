using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_M
{
    internal class Contacts
    {
      
        private List<User> user { get; set; }
        public Contacts()
        {
            user = new List<User>();
        }

        public void AddUser(User _user)
        {
            user.Add(_user);
        }
        public void EditUser(int id,User newvalue)
        {
            User founduser = user.FirstOrDefault(x => x.Id == id);

            if (founduser != null)
            {
                user[user.IndexOf(founduser)] = newvalue;
            }
            else
            {
                Console.WriteLine("not found user");
            }
        }
        public void DeleteUser(int id)
        {

            User founduser = user.FirstOrDefault(x => x.Id == id);

            if (founduser != null)
            {
                user.Remove(founduser);
                 founduser.Show();
            }
            else
            {
                Console.WriteLine("not found user");
            }
        }
        public int count()
        {
            return user.Count();
        }
        // Search for users based on any data
        public User Search(string searchTerm)
        {
            return  user.FirstOrDefault(x => x.Id == int.Parse(searchTerm));


        }
        public void PrintAllUsers()
        {
            if(user.Count == null)
            {
                Console.WriteLine("Not found User");
            }
            else
            {
                user.ForEach(x => {
                    x.Show();
                    Console.WriteLine("-------------------------");

                    });
            }
        }

    }
}
