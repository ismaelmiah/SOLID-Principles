namespace OCP
{
    public class SummerDiscount : IDiscountCalculate
    {
        public bool Rule(string rule)
        {
            return rule.Equals("Summer");
        }

        public double Calculate(int amount)
        {
            return amount * 0.10;
        }
    }
}