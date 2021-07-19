using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class Baza_Accounts
    {
        public List<Accond> Acconds { get; set; }
        public int Count { get; set; }

        public Baza_Accounts()
        {
            Acconds = new List<Accond>();
            Count = 0;
        }
        public Baza_Accounts(Accond New_accond)
        {
            Acconds = new List<Accond>();
            Acconds.Add(New_accond);
            ++Count;
        }
        public void Add_accound(Accond accond)
        {
            Acconds.Add(accond);
            ++Count;
        }
    }
}
