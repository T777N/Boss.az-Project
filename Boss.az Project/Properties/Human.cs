using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class Human
    {
        static int ID_count_HUMAN = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public int ID_HUMAN { get; set; }

        public Human()
        {
            Name = string.Empty;
            Surname = string.Empty;
            City = string.Empty;
            Phone = string.Empty;
            Age = 0;
            ID_HUMAN = 0;
        }
        public Human(string name, string surname, string city, string phone, int age)
        {
            Name = name;
            Surname = surname;
            City = city;
            Phone = phone;
            Age = age;
            ID_HUMAN = ID_count_HUMAN + 1;
            ++ID_count_HUMAN;
        }
    }
}
