using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            Thread.Sleep(3000);
            s.Stop();
            s.CalculateDuration();
            s.Start();
            Thread.Sleep(1000);
            s.Start();
            Thread.Sleep(3000);
            s.Stop();
            s.CalculateDuration();
        }
    }
}
