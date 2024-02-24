using EFCoreWithRepPattern.IRepository;
using EFCoreWithRepPattern.Models;
using EFCoreWithRepPattern.Repository;
using log4net;
using log4net.Config;
using System.Reflection;
using System.Reflection.Metadata;
 

namespace EFCoreWithRepPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            builder.Services.AddDbContext<AmityDbContext>();
            builder.Services.AddScoped<IRepo,Repo>();
            builder.Services.AddControllersWithViews();
             var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}