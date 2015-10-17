using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class HourMinuteHand
    {
        public void CalculateAngle(DateTime time)
        {
            int minute = time.Minute;
            int hour = time.Hour;

            int hourAngle = (hour % 12) * (1 / 12) * 360 + (minute * 1 / 60 * 1/12 * 360);
            int minuteAngle = minute * 1 / 60 * 360;

            int difference = Math.Abs(hourAngle - minuteAngle);
        }
    }
}
