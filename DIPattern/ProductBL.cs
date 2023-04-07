using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPattern
{
    public class ProductBL
    {
        // ProductDB db = new ProductDB();

        IProductDB db; // null

        public ProductBL(IProductDB d)
        {
            db = d;
        }

        //public IProductDB Dependency
        //{
        //    set
        //    {
        //        db = value;
        //    }
        //}

        //public void Register(IProductDB d)
        //{
        //    db = d;
        //}

        public void Create()
        {
            // ProductDB db = new ProductDB();
            db.Create();
        }

        public List<Product> GetAll()
        {
            // ProductDB db = new ProductDB();
            return db.GetAll();
        }
    }
}
