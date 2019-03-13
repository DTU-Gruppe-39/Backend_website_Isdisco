using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsDisco.Models
{
    public class User
    {
        string name;
        int ID;
        Boolean VIP;
  
        public User(string name, int ID)
        {
            this.name = name;
            this.ID = ID;
            VIP = false;
        }

        private void SetVIP()
        {
            VIP = true;
        }
        
    }
}
