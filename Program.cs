using _2492024WebLab;

internal class Program
{
    static List<Employee> employeeList = new List<Employee>();
    private static void Main(string[] args)
    {


        var worker = new Employee("Koby Hills", "D65", 35);
        var workerOne = new Employee("Boby Bills", "B65", 42);
        var workerTwo = new Employee("Hoby Kills", "H65", 36);

        employeeList.Add(worker);
        employeeList.Add((Employee)workerOne);
        employeeList.Add((Employee)workerTwo);

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
                    addEmployee(); break;
                case "2":
                    deleteEmployee(); break;
                case "3":
                    displayEmployees(); break;
                case "4":
                    Online = false;
                    Console.WriteLine("Cya next time"); break;
                default:
                    Console.WriteLine("Error: number between 1 and 4"); break;
            }


            /*addEmployee();
            displayEmployees();*/

            static void addEmployee()
            {
                string NewEmployeeName = Employee.getValidEmployeeName();
                string newEmployeeId = Employee.getValidEmployeeId();
                double hoursWored = Employee.getValidEmployeeHours();

                var newEmployee = new Employee(NewEmployeeName, newEmployeeId, hoursWored);

                employeeList.Add(newEmployee);

                Console.WriteLine($"Employee added:  {newEmployee.ToString()}");
            }

            static void displayEmployees()
            {
                Console.WriteLine("List of Employees: ");
                foreach (Employee employee in employeeList)
                {
                    Console.WriteLine(employee.ToString());
                    Console.WriteLine($"Wage is: ${employee.CalculateWage()}");

                }
            }
            static void deleteEmployee()
            {
                displayEmployees();
                if (employeeList.Count == 0)
                {
                    Console.WriteLine("No employees found");
                    return;
                }

                int position;
                Console.Write($"Enter position to delete (1 to {employeeList.Count})");

                while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > employeeList.Count)
                {
                    Console.WriteLine($"Invalid output, please select from (1 to {employeeList.Count})");
                }
                int index = position - 1;
                Employee employeeToRemove = employeeList[index];
                employeeList.RemoveAt(index);

                Console.WriteLine($"Employee {employeeToRemove.eName}(ID: {employeeToRemove.eId}) has been removed.");
                }

        }
    }
}
