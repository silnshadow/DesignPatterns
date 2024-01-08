using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterns
{
    public class BillingContext
    {
        private IPricingStrategy _pricingStrategy;

        public BillingContext(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
        }

        public double CalculateTotal(double productPrice)
        {
            return _pricingStrategy.CalculatePrice(productPrice);
        }
    }
}
