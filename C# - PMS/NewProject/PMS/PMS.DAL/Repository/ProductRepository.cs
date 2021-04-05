using AutoMapper;
using PMS.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly PMSDBEntities _PMSDBContext;

        public ProductRepository()
        {
            _PMSDBContext = new PMSDBEntities();
        }



        public string AddProduct(Product product)
        {
            if(product!= null)
            {

                _PMSDBContext.Products.Add(product);
                int x = _PMSDBContext.SaveChanges();
                return x > 0 ? "Add Successfully" : "Something went wrong";

            }
            return "Model null found";
        }

        public bool DeleteProduct(int id)
        {
            if(id!= null)
            {
                var ent = _PMSDBContext.Products.Find(id);
                if (ent != null)
                {
                    _PMSDBContext.Products.Remove(ent);
                    _PMSDBContext.SaveChanges();
                    return true;
                }
                return false;
            }
            return false;
        }

        public List<Product> GetProducts()
        {
            return _PMSDBContext.Products.ToList();
        }

        public string UpdateProduct(Product product)
        {
           
            
            var ent = _PMSDBContext.Products.Find(product.ProductID);
            if(ent!= null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, Database.Product>());
                var mapper = new Mapper(config);
                mapper.Map(product, ent);
                _PMSDBContext.SaveChanges();


                _PMSDBContext.SaveChanges();
                return "update Successfully" ;
            }
            return "Model null found";

        }
    }
}
