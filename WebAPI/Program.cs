using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.absract;
using Business.concrete;
using Business.DependencyResolvers.AutoFac;
using DataAccess.absract;
using DataAccess.concrete.EntityFrameWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(p=>
    p.RegisterModule(new AutoFacBusinessModule())
    );

//builder.Services.AddSingleton<IProductService,ProductManager>();
//builder.Services.AddSingleton<IProductDal, EfProductDal>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
