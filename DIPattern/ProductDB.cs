using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPattern
{
    public interface IProductDB
    {
        void Create();
        List<Product> GetAll();
    }

    public class ProductDB : IProductDB
    {
        public void Create()
        {
            // db code to insert product to product table
            Console.WriteLine("Product created successfully");
        }

        public List<Product> GetAll()
        {
            // db code to retrieve fetch all product from product table
            Console.WriteLine("Product fetched successfully");

            return new List<Product>();
        }
    }
}

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int UnitPrice { get; set; }
}
