using Bussinies.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinies.Concrete
{
    public class ProductManager : IProductManager
    {
        IProductDal _productDal;

        public ProductManager(IProductDal ProductDal)
        {
            _productDal = ProductDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice<=min && p.UnitPrice<=max);
        }
    }
}
