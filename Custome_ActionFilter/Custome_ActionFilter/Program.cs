using Custome_ActionFilter.CustomeFilter;
using Custome_ActionFilter.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddMvcOptions(opt => opt.Filters.Add(new ActionLogFilter()));
builder.Services.AddDbContext<Context>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("scon")));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();
app.Run();
