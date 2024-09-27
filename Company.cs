using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2492024WebLab
{
    public class Company
    {
        private List<Employee> employeeList = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employeeList.Add(employee);
            Console.WriteLine("Employee added");
        }

        public void DisplayEmployees()
        {
            if (employeeList.Count == 0)
            {
                Console.WriteLine("Empty company");
                return;
            }

            Console.WriteLine("List of Employees: ");
            int index = 1;
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"{index}: {employee.ToString()}");
                Console.WriteLine($" Wage is: ${employee.Salary.CalculateWage()}");
                index++;
            }
        }

        public void DeleteEmployee(int position)
        {
            if (position < 1 || position > employeeList.Count)
            {
                Console.WriteLine("Invalid position");
                return; 
            }

            int index = position - 1;
            Employee employeeRemoved = employeeList[index];
            employeeList.RemoveAt(index);
            Console.WriteLine($"Employee {employeeRemoved.EName} (ID: {employeeRemoved.EId}) has been fired");
        }
        public int HeadCount()
        { 
        return employeeList.Count;
        }

    }
}
