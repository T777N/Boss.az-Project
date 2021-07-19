using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class Baza_Mesaj
    {
        public List<Mesages> mesages { get; set; }
        public int Count { get; set; }
        public Baza_Mesaj()
        {
            mesages = new List<Mesages>();
        }
        public Baza_Mesaj(Mesages NEW_mesages)
        {
            mesages = new List<Mesages>();
            mesages.Add(NEW_mesages);
            ++Count;
        }
        public void Add_mesagge(Mesages NEW_mesages)
        {
            mesages.Add(NEW_mesages);
            ++Count;
        }
        public void Show()
        {
            if (Count != 0)
            {

            for (int i = 0; i < Count; i++)
            {
                    mesages[i].Show();
                    Console.WriteLine(" - - - - - - - - - - - - - - - ");
            }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" Empty ");
                Console.WriteLine();
            }
        }
    }
}
