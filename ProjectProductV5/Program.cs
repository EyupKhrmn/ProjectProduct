using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Manager;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ProjectProductV5
{
    public class Program
    {
        public static void Main(string[] args)
        {

            CategoryManager cm = new CategoryManager();
            foreach (var item in cm.GetAll())
            {
                Console.WriteLine($"ID: {item.CategoryId} Kategori Adı: {item.Name}");
            }
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}