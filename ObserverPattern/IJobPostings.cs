using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverPattern
{
    interface IJobPostings
    {
        void Attach(IJobSeeker jobSeeker);
        void Detach(IJobSeeker jobSeeker);
        void Notify(Job job);

    }
}
