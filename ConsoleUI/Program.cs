using Business.concrete;

using DataAccess.concrete.EntityFrameWork;
using DataAccess.concrete.InMemory;
using entities.concrete;

ProductManager productManager = new ProductManager(new EfProductDal());
var result =productManager.GetAll();
foreach (var product in result.Data)
{
    Console.WriteLine(product.ProductName);
}
CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());



