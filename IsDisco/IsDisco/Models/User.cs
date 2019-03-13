using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsDisco.Models
{
    public class User
    {
       public string name
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
  
        public User(string name, int ID)
        {
            this.name = name;
            this.ID = ID;
            VIP = false;
        }

     /*  private void SetVIP()
        {
            VIP = true;
        }
     */
    }
}
