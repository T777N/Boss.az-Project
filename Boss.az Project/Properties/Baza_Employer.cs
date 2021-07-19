using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class Baza_Employer
    {
        public List<Employer> employers {get;set;}
        public int Count_employers { get; set; }
        public Baza_Employer()
        {
            employers = new List<Employer>();
            Count_employers = 0;
        }
        public Baza_Employer(Employer employer)
        {
            employers = new List<Employer>();
            employers.Add(employer);
            ++Count_employers;
        }
        public void Add_Employer(Employer employer)
        {
            employers.Add(employer);
            ++Count_employers;
        }
       
    }
}
