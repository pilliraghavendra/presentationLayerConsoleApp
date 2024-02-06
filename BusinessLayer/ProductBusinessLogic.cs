using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductBusinessLogic
    {
        ProductDetails ProductDetails=new ProductDetails();
        public List<Product> GetDisplayDataDB()
        {
            return ProductDetails.GetListOfProducts();
        }
    }
}
