using _2492024WebLab;

internal class Program
{
    static List<Employee> employeeList = new List<Employee>();
    private static void Main(string[] args)
    {


        var worker = new Employee("Koby Hills", "D65", 35);
        var workerOne = new Employee("Boby Bills", "B65", 35);
        var workerTwo = new Employee("Hoby Kills", "H65", 35);

        employeeList.Add(worker);
        employeeList.Add((Employee)workerOne);  
        employeeList.Add((Employee)workerTwo);

        /*Console.WriteLine($"Salary is £ ${worker.CalculateWage()}");

        Console.WriteLine(worker.ToString());*/

        addEmployee();
        displayEmployees();

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

            }
        }
    }
}
