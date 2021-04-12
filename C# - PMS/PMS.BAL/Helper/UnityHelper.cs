using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Extension;
using Unity;
using PMS.DAL.Repository;

namespace PMS.BAL.Helper
{
    public class UnityHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IProductRepository, ProductRepository>();
        }
    }
}
