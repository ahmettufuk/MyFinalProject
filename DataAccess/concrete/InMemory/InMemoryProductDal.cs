using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.absract;
using entities.concrete;

namespace DataAccess.concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product
                {
                    ProductId = 1, CategoryId = 1, ProductName = "Laptop", UnitsInStock = 15, UnitPrice = 12000
                },
                new Product
                {
                ProductId = 2, CategoryId = 1, ProductName = "Computer", UnitsInStock = 15, UnitPrice = 9000
                },
                new Product
                {
                    ProductId = 3, CategoryId = 2, ProductName = "Glass", UnitsInStock = 25, UnitPrice = 55
                } ,
                new Product
                {
                    ProductId = 4, CategoryId = 3, ProductName = "Chair", UnitsInStock = 10, UnitPrice = 95
                },
                new Product
                {
                    ProductId = 5, CategoryId = 3, ProductName = "Table", UnitsInStock = 8, UnitPrice = 176
                }

            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            productToDelete = _products.SingleOrDefault(p=> p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public void Update(Product product)
        {
            Product productToUpdate = null;
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }
    }
}
