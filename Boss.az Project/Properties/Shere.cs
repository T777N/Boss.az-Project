using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class Share
    {
        public static int Id_count { get; set; } = 0;
        
        public int ID { get; set; }
        public string Name { get; set; }
        public String About { get; set; }
        public string Price { get; set; }

        public string Category { get; set; }
        public Share()
        {
            ID = 0;
            Name = string.Empty;
            About = string.Empty;
            Price = string.Empty;
            Category = string.Empty;

        }
        public Share(string name,string about,string price,string category)
        {
            Name = name;
            About = about;
            Price = price;
            Category = category;
            ID = Id_count + 1;
            ++Id_count;
        }
        public void ID_null()
        {
            Id_count = 0;
        }
        public void Show()
        {
            
            Console.WriteLine($" Share Category : {Category}   ");
            Console.WriteLine($" Name : {Name}                 ");
            Console.WriteLine($" About : {About}               ");
            Console.WriteLine($" Price {Price}                 ");
            Console.WriteLine($" ID : {ID}                     ");
            Console.WriteLine();
            Console.WriteLine(" --------------------");
            Console.WriteLine();
        }
    }
}
