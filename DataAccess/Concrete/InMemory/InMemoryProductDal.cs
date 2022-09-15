using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { new Product { ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 10, UnitsInStock = 5 } };
            _products = new List<Product> { new Product { ProductId = 2, CategoryId = 1, ProductName = "kamera", UnitPrice = 500, UnitsInStock = 3 } };
            _products = new List<Product> { new Product { ProductId = 3, CategoryId = 2, ProductName = "telefon", UnitPrice = 1500, UnitsInStock = 2 } };
            _products = new List<Product> { new Product { ProductId = 4, CategoryId = 2, ProductName = "klavye", UnitPrice = 150, UnitsInStock = 65 } };
            _products = new List<Product> { new Product { ProductId = 5, CategoryId = 2, ProductName = "fare", UnitPrice = 85, UnitsInStock = 1 } };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product ProductToDelete;
            ProductToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product ProductUpdate;
            ProductUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }
    }
}
