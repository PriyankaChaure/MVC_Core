using Microsoft.EntityFrameworkCore;
using MultipleInput.Models;
using MultipleInput.Reposiratories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IEmp, RepoEmp>();
builder.Services.AddScoped<ISkill, RepoSkill>();
builder.Services.AddDbContextPool<ContextClass>(opt => opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("scon")));
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();
app.Run();
