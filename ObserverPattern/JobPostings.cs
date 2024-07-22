using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverPattern
{
    class JobPostings : IJobPostings
    {
        private List<IJobSeeker> _jobSeekers = new List<IJobSeeker>();
        public void Attach(IJobSeeker jobSeeker)
        {
            _jobSeekers.Add(jobSeeker);
        }

        public void Detach(IJobSeeker jobSeeker)
        {
            _jobSeekers.Remove(jobSeeker);
        }

        public void Notify(Job job)
        {
            foreach(var jobSeeker in _jobSeekers)
            {
                jobSeeker.Notify(job);
            }
        }

        public void AddJob(Job job)
        {
            Notify(job);
        }
    }
}
