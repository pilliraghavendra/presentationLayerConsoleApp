using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLayer;

namespace presentationLayerConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductBusinessLogic productBusinessLogic = new ProductBusinessLogic();

            List<Product> result = productBusinessLogic.GetDisplayDataDB();

            foreach (Product p in result)
            {
                Console.WriteLine(p.Id + " " +p.Name+" " + p.Description + " "  + p.Prize);
            }

            Console.ReadLine();
        }
    }
}
