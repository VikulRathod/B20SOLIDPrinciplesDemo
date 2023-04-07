using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPattern
{
    public class ProductOracleDB : IProductDB
    {
        public void Create()
        {
            // db code to insert product to product table
            Console.WriteLine("Oracle Product created successfully");
        }

        public List<Product> GetAll()
        {
            // db code to retrieve fetch all product from product table
            Console.WriteLine("Oracle Product fetched successfully");

            return new List<Product>();
        }
    }
}
