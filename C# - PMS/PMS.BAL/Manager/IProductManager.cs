using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Model;

namespace PMS.BAL.Manager
{
    public interface IProductManager
    {
        List<Product> GetProducts();

        string AddProduct(Product product);

        string UpdateProduct(Product product);

        bool DeleteProduct(int id);
    }
}
