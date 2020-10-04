namespace SRP
{
    /*
     *This class name can be Salary
     * And in this class the calculate method and Print method can work
     * properly. But this things is un-valid for Single Responsive Principle
     * So I create another class for Print Only. And divide their response
     * as SRP rules(One Class Should have one reason to change/One class should behave as one responsible).
     */
    public class CalculateSalary
    {
        public int NumberOfDays { get; set; }
        public double PerDays { get; set; }

        public double Salary()
        {
            return this.NumberOfDays * this.PerDays;
        }
    }
}