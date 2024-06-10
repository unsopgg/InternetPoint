using Blazored.LocalStorage;
using InternetPoint.Models;
using InternetPoint.Pages;
using InternetPoint.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace InternetPoint
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddAuthorization();
            var connectionString = "Server=localhost;Port=5432;Database=ТелеТочка;User ID=postgres; Password=446556; Include Error Detail=true";
            builder.Services.AddDbContextFactory<MyDbContext>(opt => opt.UseNpgsql(connectionString));
            var UserconnectionString = "Server=localhost;Port=5432;Database=ТелеТочка;User ID=postgres; Password=446556; Include Error Detail=true";
            builder.Services.AddDbContextFactory<UserDbContext>(opt => opt.UseNpgsql(UserconnectionString));
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<UserStateService>();
            builder.Services.AddScoped<UserService>();
            builder.Services.AddScoped<PlugTariffService>();
            var app = builder.Build();


        

        app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}