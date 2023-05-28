using F5Education.Web.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System.Text.Json;

namespace F5Education.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllers();
            builder.Services.AddTransient<JsonFileCoursesService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllers();
            app.MapRazorPages();

            //app.MapGet("/courses", (context) =>
            //{
            //    var _courses = app.Services.GetService<JsonFileCoursesService>().GetCourses();
            //    var json = JsonSerializer.Serialize(_courses);
            //    return context.Response.WriteAsync(json);
            //});

            app.Run();
        }
    }
}