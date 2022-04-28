using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.AutoFac;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(builder =>
                {
                    builder.RegisterModule(new AutofacBusinessModule());
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
//using Autofac;
//using Autofac.Extensions.DependencyInjection;
//using Business.Abstract;
//using Business.Concrete;
//using Business.DependencyResolves.AutoFac;
//using DataAccess.Abstract;
//using DataAccess.Concrete.EntityFramework;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
////builder.Services.AddSingleton<ICarService, CarManager>();
////builder.Services.AddSingleton<ICarDal, EfCarDal>();
////builder.Services.AddSingleton<IBrandService, BrandManager>();
////builder.Services.AddSingleton<IBrandDal, EfBrandDal>();
////builder.Services.AddSingleton<IColorService, ColorManager>();
////builder.Services.AddSingleton<IColorDal, EfColorDal>();
////builder.Services.AddSingleton<IRentalService, RentalManager>();
////builder.Services.AddSingleton<IRentalDal, EfRentalDal>();
////builder.Services.AddSingleton<IUserService, UserManager>();
////builder.Services.AddSingleton<IUserDal, EfUserDal>();
////builder.Services.AddSingleton<ICustomerService, CustomerManager>();
////builder.Services.AddSingleton<ICustomerDal, EfCustomerDal>();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
//    .ConfigureContainer<ContainerBuilder>(builder =>
//    {
//        builder.RegisterModule(new AutofacBusinessModule());
//    });


//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
//using Autofac;
//using Autofac.Extensions.DependencyInjection;
//using Business.DependencyResolvers.Autofac;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace WebApi
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            CreateHostBuilder(args).Build().Run();
//        }

//        public static IHostBuilder CreateHostBuilder(string[] args) =>
//            Host.CreateDefaultBuilder(args)
//                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
//                .ConfigureContainer<ContainerBuilder>(builder =>
//                {
//                    builder.RegisterModule(new AutofacBusinessModule());
//                })
//                .ConfigureWebHostDefaults(webBuilder =>
//                {
//                    webBuilder.UseStartup<Startup>();
//                });
//    }
//}