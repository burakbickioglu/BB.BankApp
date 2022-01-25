using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BB.BankApp.Web.Data.Context;
using BB.BankApp.Web.Data.Interfaces;
using BB.BankApp.Web.Data.Repositories;
using BB.BankApp.Web.Data.UnitOfWork;
using BB.BankApp.Web.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BB.BankApp.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) 
        {

            services.AddDbContext<BankContext>(opt =>
            {
                opt.UseSqlServer("server=(localdb)\\mssqllocaldb; database=BankDb; integrated security=true;");
            });
            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            //services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IUow, Uow>();
            services.AddScoped<IAccountMapper, AccountMapper>();
            services.AddScoped<IUserMapper, UserMapper>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
