using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainLibraryKek
{
    public class Calculations
    {

        public static string AvailablePeriod(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            TimeSpan[] endTimes = new TimeSpan[startTimes.Length];
            TimeSpan[] jendTimes = new TimeSpan[startTimes.Length];

            List<string> list = new List<string>();
            

            while (beginWorkingTime.Add(new TimeSpan(0, consultationTime, 0)) <= endWorkingTime)
            {
                int count = 0;
                int jcount = 0;
                endTimes = new TimeSpan[startTimes.Length];
                for (int i = 0; i < startTimes.Length; i++)
                {
                    endTimes[i] = startTimes[i].Add(new TimeSpan(0, durations[i], 0));
                    for (int j = 1; j < startTimes.Length-1; j++)
                    {
                        jendTimes[j] = startTimes[j].Add(new TimeSpan(0, durations[j], 0));

                        if (beginWorkingTime.Add(new TimeSpan(0, consultationTime, 0)) > startTimes[j] && beginWorkingTime.Add(new TimeSpan(0,durations[j], 0)) <= jendTimes[j])
                        {
                            beginWorkingTime = jendTimes[j];
                            jcount++;
                        }
                        if (beginWorkingTime >= startTimes[i] && beginWorkingTime.Add(new TimeSpan(0, durations[i], 0)) <= endTimes[i] )
                        {
                            beginWorkingTime = endTimes[i];
                            count++;
                        }
                        if (beginWorkingTime.Add(new TimeSpan(0, consultationTime, 0)) > startTimes[i] && beginWorkingTime.Add(new TimeSpan(0, 10, 0)) <= endTimes[i])
                        {
                            beginWorkingTime = endTimes[i];
                            count++;
                        }
                    }
                    
                }
                if (count == 0 && jcount == 0)
                {
                    string data = $"{beginWorkingTime} - {beginWorkingTime.Add(new TimeSpan(0, consultationTime, 0))}";
                    beginWorkingTime = beginWorkingTime.Add(new TimeSpan(0, consultationTime, 0));
                    list.Add(data);
                }
            }
            var result = String.Join("\n", list.ToArray());
            return result;
        }
    }
}
