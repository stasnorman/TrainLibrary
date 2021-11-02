using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainLibraryKek;

namespace TrainLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan[] time = { new TimeSpan(10, 00, 00), new TimeSpan(11, 00, 00), new TimeSpan(15, 00, 00), new TimeSpan(15, 30, 00), new TimeSpan(16, 50, 00) };

            int[] durationSet = { 60, 30, 10, 10, 40 };
            TimeSpan beginWorkingTime = new TimeSpan(9, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(17, 0, 0);
            int consul = 30;

            Console.WriteLine(Calculations.AvailablePeriod(time, durationSet, beginWorkingTime, endWorkingTime, consul));
            Console.ReadKey();
        }
    }
}
