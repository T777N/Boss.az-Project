using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class Baza_Workers
    {
        public List<Worker> workers { get; set; }
        public int Count_workers { get; set; }
        public Baza_Workers()
        {
            workers = new List<Worker>();
            Count_workers = 0;
        }
        public Baza_Workers(Worker worker)
        {
            ++Count_workers;
            workers = new List<Worker>();
            workers.Add(worker);
        }
        public void Add_worker(Worker New_worker)
        {
            ++Count_workers;
            workers.Add(New_worker);
        }
    }
}
