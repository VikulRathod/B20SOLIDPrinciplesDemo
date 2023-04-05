namespace FactoryPattern
{
    public class CustomerFactory
    {
        static Dictionary<string, Customer> customers;

        static CustomerFactory()
        {
            customers = new Dictionary<string, Customer>();
            customers.Add("NORMAL", new Customer());
            customers.Add("SILVER", new SilverCustomer());
            customers.Add("GOLD", new GoldCustomer());
            customers.Add("PLATINUM", new PlatinumCustomer());
        }

        public static Customer Create(string cType)
        {
            //switch (cType)
            //{
            //    case "SILVER":
            //        return new SilverCustomer();
            //    case "GOLD":
            //        return new GoldCustomer();
            //    case "PLATINUM":
            //        return new PlatinumCustomer();
            //    default:
            //        return new Customer();
            //}

            if (customers.ContainsKey(cType))
            {
                return customers[cType];
            }
            else
            {
                return customers["NORMAL"];
            }
        }
    }
}
