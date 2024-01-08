using ObserverPattern;
using StrategyPatterns.Strategies;

namespace StrategyPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StrategyPatternDriverCode();

            ObserverPatternDriverCode();
            Console.ReadKey();
        }

        static void StrategyPatternDriverCode()
        {
            // Create instances of different strategies
            IPricingStrategy regularPricing = new RegularPricingStrategy();
            IPricingStrategy discountedPricing = new DiscountedPricingStrategy();
            IPricingStrategy premiumPricing = new PremiumPricingStrategy();

            // Create context instances using different strategies
            BillingContext regularBilling = new BillingContext(regularPricing);
            BillingContext discountedBilling = new BillingContext(discountedPricing);
            BillingContext premiumBilling = new BillingContext(premiumPricing);

            // Test the strategies
            double productPrice = 100; // Assuming product price is $100

            Console.WriteLine("Regular Billing: $" + regularBilling.CalculateTotal(productPrice));
            Console.WriteLine("Discounted Billing: $" + discountedBilling.CalculateTotal(productPrice));
            Console.WriteLine("Premium Billing: $" + premiumBilling.CalculateTotal(productPrice));
        }

        static void ObserverPatternDriverCode()
        {
            Stock stock = new Stock();

            // Creating investors
            Investor investor1 = new Investor("John");
            Investor investor2 = new Investor("Alice");

            // Registering investors with the stock
            stock.Attach(investor1);
            stock.Attach(investor2);

            // Changing the stock price notifies the investors
            stock.Price = 100; // Notifies both investors
            stock.Price = 150; // Notifies both investors again

            // Unregistering an investor
            stock.Detach(investor2);
            stock.Price = 200; // Only notifies investor1
        }
    }
}