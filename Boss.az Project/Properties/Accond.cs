using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class Accond
    {
        public string Username { get; set; }
        public string Password { get; set; }
        
        public Accond()
        {
            Username = string.Empty;
            Password = string.Empty;
        }
        public Accond(string name,string parol)
        {
            Username = name;
            Password = parol;
        }
    }
}
