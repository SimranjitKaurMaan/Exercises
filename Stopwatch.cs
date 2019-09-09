using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Stopwatch
    {
        private DateTime StartTime;
        private DateTime StopTime;
        private TimeSpan Duration;
        private bool IsStarted;


        public void Start()
        {
            if (IsStarted == false)
            {
                StartTime = DateTime.Now;
                IsStarted = true;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Stop()
        {
            if (IsStarted == true)
            {
                StopTime = DateTime.Now;
                IsStarted = false;
            }

        }

        public void CalculateDuration()
        {
            Duration = StopTime - StartTime;
            Console.WriteLine("Duration in seconds(s) : {0}",Duration);
        }
    }
}
