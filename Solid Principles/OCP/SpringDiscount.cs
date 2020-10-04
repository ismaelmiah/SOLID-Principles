namespace OCP
{
    public class SpringDiscount : IDiscountCalculate
    {
        public bool Rule(string rule)
        {
            return rule.Equals("Spring");
        }

        public double Calculate(int amount)
        {
            return amount * 0.20;
        }
    }
}