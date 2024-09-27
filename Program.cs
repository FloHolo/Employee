using _2492024WebLab;
using System.Reflection;

internal class Program
{
    static Company company = new Company();
    private static void Main(string[] args)
    {


        var worker = new Employee("Koby Hills", "D65", new Wage(35));
        var workerOne = new Employee("Boby Bills", "B65", new Wage(42));
        var workerTwo = new Employee("Hoby Kills", "H65", new Wage(36));

        company.AddEmployee(worker);
        company.AddEmployee((Employee)workerOne);
        company.AddEmployee((Employee)workerTwo);

        bool Online = true;
        while (Online)
        {
            Console.WriteLine("\nWelcome to the Employee Management Menu");
            Console.WriteLine("1: Add an Employee");
            Console.WriteLine("2: Delete Employee");
            Console.WriteLine("3: Display all Employees");
            Console.WriteLine("4: Quit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddEmployee(); break;
                case "2":
                    DeleteEmployee(); break;
                case "3":
                    company.DisplayEmployees(); break;
                case "4":
                    Online = false;
                    Console.WriteLine("Cya next time"); break;
                default:
                    Console.WriteLine("Error: number between 1 and 4"); break;
            }

            static void AddEmployee()
            {
                string NewEmployeeName = GetValidEmployeeName();
                string newEmployeeId = GetValidEmployeeId();
                double hoursWorked = GetValidEmployeeHours();

                Wage wage = new Wage(hoursWorked);

                var newEmployee = new Employee(NewEmployeeName, newEmployeeId, wage);

                company.AddEmployee(newEmployee);

                Console.WriteLine($"Employee added:  {newEmployee.ToString()}");
            }

            static void DeleteEmployee()
            {
                company.DisplayEmployees();
                if (company.HeadCount() == 0)
                {
                    Console.WriteLine("No employees found");
                    return;
                }

                int position;
                Console.Write($"Enter position to delete (1 to {company.HeadCount()})");

                while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > company.HeadCount())
                {
                    Console.WriteLine($"Invalid output, please select from (1 to {company.HeadCount})");
                }
                company.DeleteEmployee(position);   
                }

            static string GetValidEmployeeName()
            {
                string name;
                do
                {
                    Console.Write("Enter Name (must be 1-50 characters): ");
                    name = Console.ReadLine();

                    if (!Employee.NameValidation(name))
                    {
                        Console.WriteLine("Error: Invalid name");
                    }
                } while (!Employee.NameValidation(name));
                return name;
            }

            static string GetValidEmployeeId()
            {
                string id;
                do
                {
                    Console.Write("Please ender ID (Letter followed by two numbers): ");
                    id = Console.ReadLine();

                    if (!Employee.IdValidation(id))
                    {
                        Console.WriteLine("Error: Invalid ID");
                    }
                } while (!Employee.IdValidation(id));
                return id;
            }
            static double GetValidEmployeeHours()/*in wages partly, validation yes, input no*/
            {
                double hours;
                do
                {
                    Console.Write("Enter hours worked (1-100): ");
                    bool isValidNumber = double.TryParse(Console.ReadLine(), out hours);
                    if (!isValidNumber || !Wage.HourValidation(hours))
                    {
                        Console.WriteLine("Error: Invalid Hours");
                    }
                } while (!Wage.HourValidation(hours));
                return hours;
            }

        }
    }
}
