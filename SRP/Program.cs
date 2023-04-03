class Customer
{
    public void Insert()
    {
        try
        {
            // db communication code
            // to customer details to database
            Console.WriteLine("Customer Created Successfully");
        }
        catch (Exception ex)
        {
            // exception information
            // database/ file/ email/ event viewer
            //  File.WriteAllText(@"Data\log.txt", ex.Message);

            //Logger logger = new Logger();
            //logger.Log(ex.Message);

            Logger.Log(ex.Message);
        }
    }
}

class Logger
{
    public static void Log(string message)
    {
        File.WriteAllText(@"Data\log.txt", message);
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer();
        customer.Insert();

        Console.ReadLine();
    }
}