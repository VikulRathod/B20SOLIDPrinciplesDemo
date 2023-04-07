using DIPattern;
using Unity;

class Program
{
    static void Main()
    {
        // ProductBL bl = new ProductBL();
        // ProductBL bl = new ProductBL(new ProductOracleDB()); // constructor injection

        //ProductBL bl = new ProductBL();
        //// bl.Dependency = new ProductDB(); // property injection
        //bl.Register(new ProductOracleDB()); // method injection


        IUnityContainer container = new UnityContainer();
        // container.RegisterType<IProductDB, ProductDB>();
        container.RegisterType<IProductDB, ProductOracleDB>();
        ProductBL bl = container.Resolve<ProductBL>();


        // ProductBL bl = new ProductBL(new ProductDB());
        bl.Create();
        var products = bl.GetAll();

        Console.ReadLine();
    }
}