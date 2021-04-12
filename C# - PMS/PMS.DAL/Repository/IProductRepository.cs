using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.DAL.Database;

namespace PMS.DAL.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();

        string AddProduct(Product product);

        string UpdateProduct(Product product);

        bool DeleteProduct(int id);


    }
}
