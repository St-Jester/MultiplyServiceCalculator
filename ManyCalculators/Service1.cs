using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ManyCalculators
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : ICalculator, ITimeCalc
    {
        public string AddMinutesToNow(double mins)
        {
            string timeNow = DateTime.Now.ToShortTimeString();
            string hoursNow = timeNow.Split(':')[0];
            string minsNow = timeNow.Split(':')[1];
            double doubleMins, doubleHours, unparsedMinsSum;


            Double.TryParse(hoursNow, out doubleHours);
            Double.TryParse(minsNow, out doubleMins);

            unparsedMinsSum = doubleMins + mins;

            double additionalHours = (int)unparsedMinsSum / 60;

            doubleHours += additionalHours;

            double parsedMins = unparsedMinsSum % 60;
            doubleMins = parsedMins;
            string normalisedMinutes = doubleMins > 9 ? doubleMins.ToString() : "0" + doubleMins.ToString();
            return $"{doubleHours}:{normalisedMinutes}";
        }

        public double Divide(double x, double y)
        {
            return x / y;

        }

        public double Mult(double x, double y)
        {
            return x * y;

        }

        public double Sub(double x, double y)
        {
            return x - y;

        }

        public double Sum(double x, double y)
        {
            return x + y;

        }
    }
}
