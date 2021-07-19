using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class CV_baza_Employer
    {
        public List<CV> CVs { get; set; }
        public int Count { get; set; }
        public CV_baza_Employer()
        {
            CVs = new List<CV>();
            Count = 0;
        }
        public CV_baza_Employer(CV NEW_cv)
        {
            CVs = new List<CV>();
            CVs.Add(NEW_cv);
            ++Count;
        }
        public void Add_cv(CV NEW_cv)
        {
            CVs.Add(NEW_cv);
            ++Count;
        }
        public void Show_cvs()
        {
            if (CVs.Count != 0)
            {

                for (int i = 0; i < CVs.Count; i++)
                {

                }
                foreach (var item in CVs)
                {
                    item.Show();

                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($@"                                                     BOSS.az          ");
                Console.WriteLine();
                Console.WriteLine($" Empty ");
                Console.WriteLine();

            }
        }
    }
}

