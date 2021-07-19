using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class Employer:Human
    {
        public List<Share> shares { get; set; }

        public static int ID_count = 0; 
        public int Vacancies { get; set; }
        public Employer()
        {
            Vacancies = 0;
            shares = new List<Share>();
        }
        public Employer(string name,string surname,string city,string phone,int age,int vacancia)
            :base(name,surname,city,phone,age)
        {
            Vacancies = vacancia;
            shares = new List<Share>();
        }
        public void Add_Employer(string name, string surname, string city, string phone, int age, int vacancia)
            
        {
            Name = name;
            Surname = surname;
            City = city;
            Phone = phone;
            Age = age;
            Vacancies = vacancia;
        }
        public void Add_share(Share new_Share)
        {
            shares.Add(new_Share);
        }
        public void Add_share_informations()
        {
            Console.Write($" Enter Name : ");
            string new_name = Console.ReadLine();
            Console.Write($" Enter About : ");
            string new_about = Console.ReadLine();
            Console.Write($" Enter Price : ");
            string new_price = Console.ReadLine();
            Console.Write($" Enter Category : ");
            string new_Category = Console.ReadLine();
            Share new_shere = new Share(new_name, new_about, new_price, new_Category);
            shares.Add(new_shere);
        }
        public void Show()
        {
            Console.WriteLine($" |  Employer Informations ");
            Console.WriteLine($" |  Name : {Name} ");
            Console.WriteLine($" |  Surname : {Surname} ");
            Console.WriteLine($" |  City : {City} ");
            Console.WriteLine($" |  Phone : {Phone} ");
            Console.WriteLine($" |  Vacancies : {Vacancies} ");
            Console.WriteLine($" |  ID : {ID_HUMAN} ");
            Console.WriteLine();
            Console.WriteLine($" Shares : ");
        }
        public void Show_shares()
        {

            if (shares != null)
            {
                for (int i = 0; i < shares.Count; i++)
                {

                    shares[i].Show();
                }

            }
            else
            {
                Console.WriteLine("          Empty ");
            }
        }
    }
}
