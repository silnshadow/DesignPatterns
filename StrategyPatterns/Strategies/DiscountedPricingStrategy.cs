using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterns.Strategies
{
    public class DiscountedPricingStrategy : IPricingStrategy
    {
        public double CalculatePrice(double productPrice)
        {
            // Apply a discount of 10%
            return productPrice * 0.9;
        }
    }
}
