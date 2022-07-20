using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.absract;
using entities.concrete;
using entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.concrete.EntityFrameWork
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext> , IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = context.Products.Join
                (context.Categories, p => p.CategoryId, c => c.CategoryId,
                    (p, c) => new ProductDetailDto
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName,
                        UnitsInStock = (short)p.UnitsInStock
                    });
                return result.ToList();

            }
        }
    }
}
