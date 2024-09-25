using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2492024WebLab
{
    internal class Employee
    {
        public String eName { get; set; }
        public string eId { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; } = 9.5;

        public Employee(string eName, string eId, double HoursWorked, double HourlyRate = 9.5)
        {
            this.eName = eName;
            this.eId = eId;
            this.HoursWorked = HoursWorked;
            this.HourlyRate = HourlyRate;
        }

        public override string ToString()
        {
            return $"{eName}({eId})";
        }

        public double CalculateWage()
        {
            return HoursWorked * HourlyRate;
        }

        public static bool NameValidation(string name)
        {
        return !string.IsNullOrWhiteSpace(name) && name.Length >= 1 && name.Length <=50;
        }

        public static bool HourValidation(double WeeklyHours)
        {
            return WeeklyHours >= 1 && WeeklyHours <= 100;
        }
        public static bool IdValidation(string id)
        {
            return Regex.IsMatch(id, @"^[A-Za-z]\d{2}$");
        }
    }
}