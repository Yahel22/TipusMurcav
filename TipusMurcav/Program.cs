using Mahlaka_Murkevet;
using TipusMurcav;

internal class program
{
    static void Main(string[] args)
    {
        Company Mycompany = new Company(5);
        for (int i = 0; i < 5; i++)
        {
            //Employee
            Console.WriteLine("Enter employee id:");
            string empId = Console.ReadLine();
            Console.WriteLine("Enter employee name:");
            string empName = Console.ReadLine();
            Console.WriteLine("Are you New Employee 1 - yes , 2 - no");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 2)
            {
                //Salary
                Console.WriteLine("Enter employee salary year:");
                int empYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee salary month:");
                int empMonth = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee brutto salary:");
                double empBrutto = Convert.ToDouble(Console.ReadLine());

                //Car
                Console.WriteLine("enter employee Car Id");
                string carId = Console.ReadLine();
                Console.WriteLine("enter employee Car Model");
                string carModel = Console.ReadLine();
                Console.WriteLine("enter employee Car Year");
                int carYear = int.Parse(Console.ReadLine());




                Salary salary = new Salary(empMonth, empYear, empBrutto);
                Car car = new Car(carId, carModel, carYear);
                Employee employee = new Employee(empId, empName, salary, car);
                Mycompany.AddNewEmployee(employee);
            }
            else
            {
                Employee employee = new Employee(empId, empName);
                Mycompany.AddNewEmployee(employee);
            }

        }
    }
}