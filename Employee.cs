using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2492024WebLab
{
    public class Employee
    {
        public String EName { get; set; }
        public string EId { get; set; }
        public Wage Salary { get; set; }

        public Employee(string eName, string eId, Wage salary)
        {
            if(!NameValidation(eName))
            {
                throw new ArgumentException("Error: Incorrect format in Name");
            }

            if (!IdValidation(eId))
            {
                throw new ArgumentException("Error: Incorrect format in ID");
            }

            this.EName = eName;
            this.EId = eId;
            this.Salary = salary;
           
        }

        public override string ToString()
        {
            return $"{EName} ({EId})";
        }

        public static bool NameValidation(string name)
        {
        return !string.IsNullOrWhiteSpace(name) && name.Length >= 1 && name.Length <=50;
        }

        public static bool IdValidation(string id)
        {
            return Regex.IsMatch(id, @"^[A-Za-z]\d{2}$");
        }
       
    }
}