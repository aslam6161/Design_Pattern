using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverPattern
{
    class JobSeeker : IJobSeeker
    {
        public string Name { get; set; }
        public JobSeeker(string name)
        {
            this.Name = name;
        }
        public void Notify(Job job)
        {
            Console.WriteLine($"Hi {Name}, new job posted: {job.Description}");
        }
    }
}
