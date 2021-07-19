using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class CV_baza
    {
        public List<CV> CVs { get; set; }
        public int Count { get; set; }
        public CV_baza()
        {
            CVs = new List<CV>();
            Count = 0;
        }
        public CV_baza(CV NEW_cv)
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
        public void Add_cv_Information()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($@"                                                     BOSS.az          ");
            Console.WriteLine();
            Console.Write($" Enter Speciality : ");
            string new_spe = Console.ReadLine();
            Console.Write($" Enter School : ");
            string new_school = Console.ReadLine();
            Console.Write($" Enter Universitet : ");
            string new_uni = Console.ReadLine();
            Console.Write($" Enter Skills : ");
            string new_skil = Console.ReadLine();
            Console.Write($" Enter Company : ");
            string new_comp = Console.ReadLine();
            Console.Write($" Enter Date : ");
            string new_date = Console.ReadLine();
            Console.Write($" Enter Language : ");
            string new_language = Console.ReadLine();

            Console.Write($" Enter GetLink : ");
            string new_GL = Console.ReadLine();
            Console.Write($" Enter LINKEDIN : ");
            string new_Link = Console.ReadLine();
            CV cv = new CV(new_spe,new_school,new_uni,new_skil,new_comp,new_date,new_language,false,new_GL,new_Link);

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
