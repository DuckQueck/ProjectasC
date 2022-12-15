using DataAccess;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternalServices
{
     public class ProductServices : IProductServices
    {
        private readonly EshopContext _db;
        public ProductServices(EshopContext db)
        {
            _db = db;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _db.Products.Include(x => x.Reviews);
        }

    }
}
