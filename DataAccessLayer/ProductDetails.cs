using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDetails
    {
        List<Product> product=new List<Product>();

        public List<Product> GetListOfProducts()
        {
            product.Add(new Product() { Id=1, Name="Lenova", Description="Laptop", Prize=50000 });
            product.Add(new Product() { Id = 2, Name = "Dell", Description = "Laptop", Prize = 30000 });
            product.Add(new Product() { Id = 3, Name = "MSI", Description = "Laptop", Prize = 40000 });
            product.Add(new Product() { Id = 4, Name = "Asus", Description = "Laptop", Prize = 80000 });

            return product;
        }
    }
}
