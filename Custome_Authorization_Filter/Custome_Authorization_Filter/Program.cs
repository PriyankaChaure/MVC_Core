using Custome_Authorization_Filter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Session;
using Custome_Authorization_Filter.Reposiratories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<Context>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("scon")));
builder.Services.AddDistributedMemoryCache();
builder.Services.AddScoped<UserInterface, UserRepo>();
builder.Services.AddSession(opt =>
{
    opt.IdleTimeout = TimeSpan.FromMinutes(30);
    opt.Cookie.IsEssential = true;
    opt.Cookie.HttpOnly = true;
});


var app = builder.Build();

app.MapGet("/", () => "Hello World!");
//app.MapControllerRoute(
//            name: "areas",
//            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
//          );


    app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
app.MapDefaultControllerRoute();
app.UseSession();
app.Run();
