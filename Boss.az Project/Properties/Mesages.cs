using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class Mesages
    {
        public Employer employer { get; set; }
        public string Message { get; set; }
        public Mesages()
        {
            employer = new Employer();
            Message = string.Empty;
        }
        public Mesages(Employer NEW_employer, string mesaj)
        {
            employer = new Employer();
            Message = mesaj;
        }
        public void Add_message(Employer NEW_employer,string mesaj)
        {
            employer = NEW_employer;
            Message = mesaj;
        }
        public void Show()
        {
            Console.WriteLine($" Employer Name : {employer.Name} ");
            Console.WriteLine($" Employer Message : {Message} ");
        }
    }
}
