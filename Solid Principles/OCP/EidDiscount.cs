namespace OCP
{
    public class EidDiscount : IDiscountCalculate
    {
        public bool Rule(string rule)
        {
            return rule.Equals("Eid");
        }

        public double Calculate(int amount)
        {
            return amount * 0.30;
        }
    }
}