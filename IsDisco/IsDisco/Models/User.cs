using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsDisco.Models
{
    public class User
    {
       public string Name
        {
            get;
        }
       public int ID
        {
            get;
        }
        public Boolean VIP
        {
            get;
            set;
        }

        public User(string Name, int ID)
        {
            this.Name = Name;
            this.ID = ID;
            VIP = false;
            
        }
    }
}
