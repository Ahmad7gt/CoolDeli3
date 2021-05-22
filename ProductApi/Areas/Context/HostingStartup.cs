using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ProductApi.Data;

[assembly: HostingStartup(typeof(ProductApi.Areas.Identity.HostingStartup))]
namespace ProductApi.Areas.Identity
{
    public class HostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ProductContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ProductContextConnection")));

                
            });
        }
    }
}