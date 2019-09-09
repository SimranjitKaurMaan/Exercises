using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private TimeSpan _duration;
        private bool _isStarted;


        public void Start()
        {
            if (_isStarted == true)
            {
                throw new InvalidOperationException();
               
            }
           
                _startTime = DateTime.Now;
                _isStarted = true;
           
        }

        public void Stop()
        {
            if (_isStarted == false)
            {
                throw new InvalidOperationException();
                
            }

            _stopTime = DateTime.Now;
            _isStarted = false;

        }

        public void CalculateDuration()
        {
            _duration = _stopTime - _startTime;
            Console.WriteLine("Duration in seconds(s) : {0}",_duration);
        }
    }
}
