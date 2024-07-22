using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverPattern
{
    class Job
    {
        public string Description { get; set; }
        public Job(string descriptioin)
        {
            this.Description = descriptioin;
        }
    }
}
