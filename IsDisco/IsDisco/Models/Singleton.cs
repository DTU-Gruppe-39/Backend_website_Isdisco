using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsDisco.Models
{
    public class Singleton
    {
        private static Singleton instance;
        private static List<User> users = new List<User>();

        public static Singleton getInstance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public void initUsers()
        {
            users.Add(new User("Mark", 0));
            users.Add(new User("Thomas", 1));
            users.Add(new User("Rasmus", 2));
            users.Add(new User("Søren", 3));
            users.Add(new User("Magnus", 4));
            users.Add(new User("Patrick", 5));
            users.Add(new User("Marcus", 6));
            users.Add(new User("Mark2", 7));
            users.Add(new User("Thomas2", 8));
            users.Add(new User("Rasmus2", 9));
            users.Add(new User("Søren2", 10));
            users.Add(new User("Magnus2", 11));
            users.Add(new User("Patrick2", 12));
            users.Add(new User("Marcus2", 13));
            users[0].VIP = true;
            users[1].VIP = true;
            users[2].VIP = true;
            users[3].VIP = true;
            users[4].VIP = true;
            users[5].VIP = true;
            users[6].VIP = true;
            users[7].VIP = true;
            users[8].VIP = true;
            users[9].VIP = true;
            users[10].VIP = true;
            users[11].VIP = true;
            users[12].VIP = true;
            users[13].VIP = true;
        }

        public List<User> GetUsers()
        {
            return users;
        }


    }
}
