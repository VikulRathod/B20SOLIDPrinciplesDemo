//sealed class Customer
//{
//    static Customer _obj;
//    private Customer() { }

//    public static Customer Instance
//    {
//        get
//        {
//            if(_obj == null)
//            {
//                _obj = new Customer();
//            }
//            return _obj;
//        }
//    }
//}

// multithreaded application
//sealed class Customer
//{
//    static Customer _obj;
//    static object _o = new object();
//    private Customer() { }

//    public static Customer Instance
//    {
//        get
//        {
//            lock (_o)
//            {
//                if (_obj == null)
//                {
//                    _obj = new Customer();
//                }
//                return _obj;
//            }
//        }
//    }
//}

// for performance
//sealed class Customer
//{
//    static Customer _obj;
//    static object _o = new object();
//    private Customer() { }

//    public static Customer Instance
//    {
//        get
//        {
//            if (_obj == null)
//            {
//                lock (_o)
//                {
//                    if (_obj == null)
//                    {
//                        _obj = new Customer();
//                    }
//                    return _obj;
//                }
//            }
//            return _obj;
//        }
//    }
//}

// interview question 
// restrict a class to create 3 object only
sealed class Customer
{
    static Customer _obj;
    private Customer() { }

    static int _counter = 1;

    public static Customer Instance
    {
        get
        {
            if (_counter <= 3)
            {
                _obj = new Customer();
                _counter++;
            }
            else
            {
                // throw new Exception("Only 3 objects are possible");
                Console.WriteLine("Only 3 objects are possible");
            }
            return _obj;
        }
    }
}

class Program
{
    static void Main()
    {
        Customer c1 = Customer.Instance;
        Customer c2 = Customer.Instance;

        if (c1 == c2)
        {
            Console.WriteLine("EQUAL");
        }
        else
        {
            Console.WriteLine("NOT EQUAL");
        }

        Customer c3 = Customer.Instance;
        if (c1 == c3)
        {
            Console.WriteLine("EQUAL");
        }
        else
        {
            Console.WriteLine("NOT EQUAL");
        }

        Customer c4 = Customer.Instance;
        if (c3 == c4)
        {
            Console.WriteLine("EQUAL");
        }
        else
        {
            Console.WriteLine("NOT EQUAL");
        }

        Console.ReadLine();
    }
}