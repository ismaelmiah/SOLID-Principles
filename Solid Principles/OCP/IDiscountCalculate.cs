namespace OCP
{
    public interface IDiscountCalculate
    {
        public bool Rule(string rule);
        public double Calculate(int amount);
    }
}