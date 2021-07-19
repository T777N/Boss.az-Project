using Boss.az_Project.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Start start = new Start();
            Accond accond1 = new Accond("admin", "admin");
            Baza_Accounts baza = new Baza_Accounts();
            baza.Add_accound(accond1);
            start.Log_in(baza);
        }
    }
}
