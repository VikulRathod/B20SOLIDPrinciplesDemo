abstract class Customer
{
    public void GetShowTimings()
    {
        Console.WriteLine("** ALL TODAYS SHOW TIMINGS **");
    }
    public abstract int GetTicketAmount();

    // public abstract void PrintTicket();
}

interface ICustomer
{
    void PrintTicket();    
}

interface ICustomerV1 : ICustomer
{
    void FoodCollect();
}

class SilverCustomer : Customer, ICustomer
{
    public override int GetTicketAmount()
    {
        return 150;
    }

    public void PrintTicket()
    {
        Console.WriteLine("Silver Ticket Printed");
    }
}

class GoldCustomer : Customer, ICustomer
{
    public override int GetTicketAmount()
    {
        return 300;
    }

    public void PrintTicket()
    {
        Console.WriteLine("Gold Ticket Printed");
    }
}

class PlatinumCustomer : Customer, ICustomer
{
    public override int GetTicketAmount()
    {
        return 450;
    }

    public void PrintTicket()
    {
        Console.WriteLine("Platinum Ticket Printed");
    }
}

class Enquiry : Customer
{
    public override int GetTicketAmount()
    {
        return 150;
    }
}

class VIPCustomer : Customer, ICustomerV1
{
    public override int GetTicketAmount()
    {
        return 600;
    }
    public void PrintTicket()
    {
        Console.WriteLine("VIP Ticket Printed");
    }
    public void FoodCollect()
    {

    }
}


class Program
{
    static void Main()
    {
        List<Customer> customers = new List<Customer>();
        customers.Add(new SilverCustomer());
        customers.Add(new GoldCustomer());
        customers.Add(new PlatinumCustomer());
        customers.Add(new Enquiry());

        foreach (Customer item in customers)
        {
            item.GetShowTimings(); // calls from Customer class always
            int amount = item.GetTicketAmount(); // calls overriden method
            Console.WriteLine($"{item.GetType().Name} : Ticket Amount {amount}");
        }

        Console.ReadLine();
    }
}