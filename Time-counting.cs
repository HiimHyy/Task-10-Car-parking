using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Car_parking
{
    internal class Time_counting
    {
        public Time_counting(TimeOnly startTime, TimeOnly endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public double calculateCharges()
        {
            TimeSpan timeSpan;
            timeSpan = EndTime - StartTime;
            double timeSpanRounded = timeSpan.TotalSeconds;
            double Hours = Math.Ceiling(timeSpanRounded / (60 * 60));
            double charges;
            if (Hours <= 2)
                charges = Hours * 2;
            else if (Hours > 2 && Hours <= 5)
                charges = Hours * 1.75;
            else
                charges = Hours * 1.5;
            
            return charges;
        }
    }
}
