using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class Worker:Human
    {
        public List<CV> cv { get; set; }
        public Worker()
        {
            cv = default;
        }
        public Worker(string name,string surname,string city,string phone,int age,CV new_cv)
            :base(name,surname,city,phone,age)
        {
            cv = new List<CV>();
            cv.Add(new_cv);
        }
        public void Add_CV(CV new_cv)
        {
            cv.Add(new_cv);
        }
        public void Show()
        {
            Console.WriteLine($" - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.WriteLine($" Name : {Name} ");
            Console.WriteLine($" Surname : {Surname} ");
            Console.WriteLine($" City : {City} ");
            Console.WriteLine($" Phone : {Phone} ");
            Console.WriteLine($" Age : {Age} ");
            Console.WriteLine($" ID : {ID_HUMAN} ");
            Console.WriteLine($" CV : ");
            Console.WriteLine();
            if (cv != null)
            {
                foreach (var item in cv)
                {
                    item.Show();
                }
            }
            else
            {
                Console.WriteLine($" Empty ");
            }
        }

    }
}
