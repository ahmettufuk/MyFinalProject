using Business.concrete;

using DataAccess.concrete.EntityFrameWork;
using DataAccess.concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());

var result = productManager.GetAll();
var result2 = productManager.GetAllByCategory(1);
var result3 = productManager.GetByUnitPrice(40, 100);

Console.WriteLine(result3.Count);

foreach (var p in result3)
{
    Console.WriteLine($"{p.ProductName} | {p.UnitPrice:C2}");
}
