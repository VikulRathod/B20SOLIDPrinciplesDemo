//class Customer
//{
//    public string CustomerType { get; set; }
//    public void GetShowTimings()
//    {
//        Console.WriteLine("** ALL TODAYS SHOW TIMINGS **");
//    }
//    public int GetTicketAmount()
//    {
//        if (CustomerType == "SILVER")
//            return 150;
//        else if (CustomerType == "GOLD")
//            return 300;
//        else if (CustomerType == "PLATINUM")
//            return 450;
//        else
//            return 0;
//    }
//}

abstract class Customer
{
    public void GetShowTimings()
    {
        Console.WriteLine("** ALL TODAYS SHOW TIMINGS **");
    }
    public abstract int GetTicketAmount();
}

class SilverCustomer : Customer
{
    public override int GetTicketAmount()
    {
        return 150;
    }
}

class GoldCustomer : Customer
{
    public override int GetTicketAmount()
    {
        return 300;
    }
}

class PlatinumCustomer : Customer
{
    public override int GetTicketAmount()
    {
        return 450;
    }
}
class Program
{
    static void Main()
    {
        //Customer customer = new Customer();
        //customer.GetShowTimings();
        //customer.CustomerType = "GOLD";
        //int amount = customer.GetTicketAmount();
        //Console.WriteLine($"{customer.CustomerType} : Ticket Amount {amount}");

        Customer customer = new SilverCustomer();
        customer.GetShowTimings();
        int amount = customer.GetTicketAmount();
        Console.WriteLine($"Silver : Ticket Amount {amount}");

        Customer customer1 = new GoldCustomer();
        customer.GetShowTimings();
        amount = customer1.GetTicketAmount();
        Console.WriteLine($"Gold : Ticket Amount {amount}");

        Customer customer2 = new PlatinumCustomer();
        customer.GetShowTimings();
        amount = customer2.GetTicketAmount();
        Console.WriteLine($"Platinum : Ticket Amount {amount}");

        Console.ReadLine();
    }
}