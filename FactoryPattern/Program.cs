using FactoryPattern;

public class Customer
{
    public string Name { get; set; }
    public Customer()
    {
        Name = "Enquiry";
    }
}

public class SilverCustomer : Customer
{
    public SilverCustomer()
    {
        Name = "Silver";
    }
}

public class GoldCustomer : Customer
{
    public GoldCustomer()
    {
        Name = "Gold";
    }
}

public class PlatinumCustomer : Customer
{
    public PlatinumCustomer()
    {
        Name = "Platinum";
    }
}
class Program
{
    static void Main()
    {
        //Customer c1 = new Customer();
        //Console.WriteLine(c1.Name);

        //Customer c2 = new SilverCustomer();
        //Console.WriteLine(c2.Name);

        //Customer c3 = new GoldCustomer();
        //Console.WriteLine(c1.Name);

        Console.WriteLine("Please enter customer type");
        string cType = Console.ReadLine().ToUpper();
        Customer c = CustomerFactory.Create(cType);

        //switch (cType)
        //{
        //    case "SILVER":
        //        c = new SilverCustomer();
        //        break;
        //    case "GOLD":
        //        c = new GoldCustomer();
        //        break;
        //    default:
        //        c = new Customer();
        //        break;
        //}

        Console.WriteLine($"Customer type: {c.Name}");

        Console.ReadLine();
    }
}