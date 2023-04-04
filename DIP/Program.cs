delegate void LogDelegate(string message);

class Customer
{
    ILogger _logger;

    public Customer(ILogger logger)
    {
        _logger = logger;
        //int logType = 1; // we will read this value from config file
        //if (logType == 1)
        //{
        //    _logger = new FileLogger();
        //}
        //else if (logType == 2)
        //{
        //    _logger = new DBLogger();
        //}
    }

    public void Insert()
    {
        try
        {
            // db code - to insert customer in database
            Console.WriteLine("Customer added to db");
        }
        catch (Exception ex)
        {
            _logger.Log(ex.Message);
            // LogDelegate del = _logger.Log;
            // LogDelegate del = (msg) => { };
        }
    }

}

interface ILogger
{
    void Log(string message);
}

class FileLogger : ILogger
{
    public void Log(string message)
    {
        File.WriteAllText(@"Data\log.txt", message + DateTime.Today.ToString());
        File.WriteAllText(@"Data\log.txt", "-------------------------------------");
    }
}

class DBLogger : ILogger
{
    public void Log(string message)
    {
        // db commucation code implement
    }
}

class EmailLogger : ILogger
{
    public void Log(string message)
    {
        // code to send email to dev team
    }
}

class Program
{
    static void Main()
    {
        // Customer customer = new Customer(new DBLogger());
        // Customer customer = new Customer(new FileLogger());
        Customer customer = new Customer(new EmailLogger());
        customer.Insert();

        Console.ReadLine();
    }
}