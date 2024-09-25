using _2492024WebLab;

internal class Program
{
    private static void Main(string[] args)
    {
        var worker = new Employee("Koby Hills", "D65", 35);



        Console.WriteLine($"Salary is £ ${worker.CalculateWage()}");

        Console.WriteLine(worker.ToString());
        GetValidEmployeeName();
        GetValidEmployeeId();
        GetValidEmployeeHours();

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
        static double GetValidEmployeeHours()
        {
            double hours;
            do
            {
                Console.Write("Enter hours worked (1-100): ");
                bool isValidNumber = double.TryParse(Console.ReadLine(), out hours);
                if (!isValidNumber || !Employee.HourValidation(hours))
                {
                    Console.WriteLine("Error: Invalid Hours");
                }
            } while (!Employee.HourValidation(hours));
            return hours;
        }
    }
}