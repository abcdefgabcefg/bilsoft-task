using BAL.ProductServices;
using DAL;
using DAL.Entities;
using DAL.Repositories;
using DAL.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var sqlServerConnectionString = Configuration.GetConnectionString("default");
            services.AddDbContext<BilSoftTaskContext>(options => options.UseSqlServer(sqlServerConnectionString));
            services.AddScoped<DbContext, BilSoftTaskContext>();

            services.AddScoped<IRepository<Product>, SqlRepository<Product>>();
            services.AddScoped<IRepository<Category>, SqlRepository<Category>>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IProductService, ProductService>();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
