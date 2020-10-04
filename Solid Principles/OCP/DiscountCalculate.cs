using System.Collections.Generic;

namespace OCP
{
    public class DiscountCalculate
    {
        public double Discount;

        //If We need some another rule we've to add another else if condition that is un-valid for OCP

        //public double CalculateDiscount(int amount, string rule)
        //{
        //    if (rule.Equals("Summer"))
        //    {
        //        Discount = amount * 0.10;
        //    }
        //    else if (rule.Equals("Spring"))
        //    {
        //        Discount = amount * 0.20;
        //    }
        //    else if (rule.Equals("Winter"))
        //    {
        //        Discount = amount * 0.25;
        //    }
        //    else if (rule.Equals("Eid"))
        //    {
        //        Discount = amount * 0.30;
        //    }
        //    return Discount;
        //}

        private List<IDiscountCalculate> _discountCalculates;

        public DiscountCalculate()
        {
            _discountCalculates = new List<IDiscountCalculate>();
            _discountCalculates.Add(new SummerDiscount());
            _discountCalculates.Add(new WinterDiscount());
            _discountCalculates.Add(new SpringDiscount());
            _discountCalculates.Add(new EidDiscount());
        }

        public double CalculateDiscount(int amount, string rule)
        {
            Discount = _discountCalculates.Find(x => x.Rule(rule)).Calculate(amount);
            return Discount;
        }
    }
}