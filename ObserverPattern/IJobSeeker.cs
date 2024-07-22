using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverPattern
{
    interface IJobSeeker
    {
        void Notify(Job job);
    }
}
