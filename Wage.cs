using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2492024WebLab
{
    public class Wage
    {
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; } = 9.5;

        public Wage(double hoursWorked, double hourlyRate = 9.5)
        {
            if (!HourValidation(hoursWorked))
            {
                throw new ArgumentException("Error: Invalid Hours");
            }
            this.HoursWorked = hoursWorked;
            this.HourlyRate = hourlyRate;
        }

        public double CalculateWage()
        {
            return HoursWorked * HourlyRate;
        }

        public static bool HourValidation(double WeeklyHours)
        {
            return WeeklyHours >= 1 && WeeklyHours <= 100;
        }
    }
}

