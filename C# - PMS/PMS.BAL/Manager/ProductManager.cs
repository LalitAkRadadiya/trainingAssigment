using PMS.DAL.Repository;
using PMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.DAL;
using AutoMapper;

namespace PMS.BAL.Manager
{
    public class ProductManager : IProductManager
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public string AddProduct(Product product)
        {
            if(product!= null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, DAL.Database.Product>());
                var mapper = new Mapper(config);
                DAL.Database.Product prod = mapper.Map<DAL.Database.Product>(product);

                return _productRepository.AddProduct(prod);
            }
            return "model null found";
        }

        public bool DeleteProduct(int id)
        {
            if (id != null)
            {
                return _productRepository.DeleteProduct(id);
            }
            else
            {
                return false;
            }
        }

        public List<Product> GetProducts()
        {
            var pd = _productRepository.GetProducts();
            List<Product> productList = new List<Product>();
            if (pd != null)
            {
                foreach (var items in pd)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Database.Product, Product>());
                    var mapper = new Mapper(config);
                    Product prod = mapper.Map<Product>(items);
                    productList.Add(prod);
                }
                return productList;
            }
            return productList;
        }

        public string UpdateProduct(Product product)
        {
            
            if (product != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, DAL.Database.Product>());
                var mapper = new Mapper(config);
                DAL.Database.Product prod = mapper.Map<DAL.Database.Product>(product);

                return _productRepository.UpdateProduct(prod);
            }
            return "model null found";
        }
    }
}
