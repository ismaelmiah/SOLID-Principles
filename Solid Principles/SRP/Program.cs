using System;

namespace SRP
{
    public class Program
    {
        public static void Main()
        {
            
            var calculatesalary = new CalculateSalary(){NumberOfDays = 5, PerDays = 12.50};
            var salary = calculatesalary.Salary();
            var printsalary = new PrintSalary();
            printsalary.Print(salary);


            Console.ReadKey(true);
        }
    }
}
