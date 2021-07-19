using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class CV
    {
        public int ID { get; set; }
        public static int ID_count { get; set; } = 0;
        public string Speciality { get; set; } // ixtisas
        public string School { get; set; }
        public string Uni_point { get; set; }//qebul bali
        public string Skills { get; set; }//bildiyi program dilleri
        public string Companies { get; set; }//islediyi companiyalar
        public string Date_startAndEnd_work { get; set; }//ise baslama ve cixma tarixi
        public string Languages { get; set; }
        public bool Honors_Diploma { get; set; }//ferqlenme diplomu
        public string GETLINK { get; set; }
        public string LINKEDIN { get; set; }

        public CV()
        {
            Speciality = string.Empty;
            School = string.Empty;
            Uni_point = string.Empty;
            Skills = string.Empty;
            Companies = string.Empty;
            Date_startAndEnd_work = string.Empty;
            Languages = string.Empty;
            GETLINK = string.Empty;
            LINKEDIN = string.Empty;
            Honors_Diploma = false;
            ID = 0;
        }
        public CV(string spe,string school,string uni,string skil,string company,string date,string language,bool HD,string getlink,string linkedin)
        {
            Speciality = spe;
            School = school;
            Uni_point = uni;
            Skills = skil;
            Companies = company;
            Date_startAndEnd_work = date;
            Languages = language;
            Honors_Diploma = HD;
            GETLINK = getlink;
            LINKEDIN = linkedin;
            ID = ID_count + 1;
            ++ID_count;
        }
        public void Show() 
        {
            Console.WriteLine($" Speciality : {Speciality} ");
            Console.WriteLine($" School : {School} ");
            Console.WriteLine($" Universitet Point : {Uni_point} ");
            Console.WriteLine($" Skills : {Skills} ");
            Console.WriteLine($" Companies : {Companies} ");
            Console.WriteLine($" Date Work : {Date_startAndEnd_work} ");
            Console.WriteLine($" Languages : {Languages} ");
            Console.WriteLine($" GETLINK : {GETLINK} ");
            Console.WriteLine($" LINKEDIN : {LINKEDIN} ");
            Console.WriteLine($" ID : {ID} ");
            if (Honors_Diploma == true)
            {
                Console.WriteLine($" Honors Diploma :    YES ");
            }
            else
            {
                Console.WriteLine($" Honors Diploma :    NO ");
            }

        }

        

    }
}
