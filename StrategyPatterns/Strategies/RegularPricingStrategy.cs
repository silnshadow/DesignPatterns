using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterns.Strategies
{
    public class RegularPricingStrategy : IPricingStrategy
    {
        public double CalculatePrice(double productPrice)
        {
            return productPrice;
        }
    }
}
