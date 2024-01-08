using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterns.Strategies
{
    public class PremiumPricingStrategy : IPricingStrategy
    {
        public double CalculatePrice(double productPrice)
        {
            // Apply a premium of 20%
            return productPrice * 1.2;
        }
    }
}
