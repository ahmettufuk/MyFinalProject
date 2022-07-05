using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.absract;
using entities.concrete;
using entities.DTOs;

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

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
