using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace HndsOn_04_HROperations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDb>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("constr")));
            builder.Services.AddScoped<ClassLibrary.HRInterface.IAdmin, ClassLibrary.HROperationsBl.AdminBl>();
            builder.Services.AddScoped<ClassLibrary.HRInterface.IEmployee, ClassLibrary.HROperationsBl.EmployeeBl>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Admin}/{action=Adminlogin}/{id?}");

            app.Run();
        }
    }
}
