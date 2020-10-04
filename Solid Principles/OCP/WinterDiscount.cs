namespace OCP
{
    public class WinterDiscount : IDiscountCalculate
    {
        public bool Rule(string rule)
        {
            return rule.Equals("Winter");
        }

        public double Calculate(int amount)
        {
            return amount * 0.25;
        }
    }
}