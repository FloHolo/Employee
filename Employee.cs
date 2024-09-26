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
        public double hoursWorked { get; set; }
        public double hourlyRate { get; set; } = 9.5;

        public Employee(string eName, string eId, double HoursWorked, double HourlyRate = 9.5)
        {
            this.eName = eName;
            this.eId = eId;
            this.hoursWorked = HoursWorked;
            this.hourlyRate = HourlyRate;
        }

        public override string ToString()
        {
            return $"{eName}({eId})";
        }

        public double CalculateWage()
        {
            return hoursWorked * hourlyRate;
        }

        public static bool nameValidation(string name)
        {
        return !string.IsNullOrWhiteSpace(name) && name.Length >= 1 && name.Length <=50;
        }

        public static bool hourValidation(double WeeklyHours)
        {
            return WeeklyHours >= 1 && WeeklyHours <= 100;
        }
        public static bool idValidation(string id)
        {
            return Regex.IsMatch(id, @"^[A-Za-z]\d{2}$");
        }
        public static string getValidEmployeeName()
        {
            string name;
            do
            {
                Console.Write("Enter Name (must be 1-50 characters): ");
                name = Console.ReadLine();

                if (!Employee.nameValidation(name))
                {
                    Console.WriteLine("Error: Invalid name");
                }
            } while (!Employee.nameValidation(name));
            return name;
        }
        public static string getValidEmployeeId()
        {
            string id;
            do
            {
                Console.Write("Please ender ID (Letter followed by two numbers): ");
                id = Console.ReadLine();

                if (!Employee.idValidation(id))
                {
                    Console.WriteLine("Error: Invalid ID");
                }
            } while (!Employee.idValidation(id));
            return id;
        }
        public static double getValidEmployeeHours()
        {
            double hours;
            do
            {
                Console.Write("Enter hours worked (1-100): ");
                bool isValidNumber = double.TryParse(Console.ReadLine(), out hours);
                if (!isValidNumber || !Employee.hourValidation(hours))
                {
                    Console.WriteLine("Error: Invalid Hours");
                }
            } while (!Employee.hourValidation(hours));
            return hours;
        }

       

    }
}