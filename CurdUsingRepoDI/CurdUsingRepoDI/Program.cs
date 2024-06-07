using CurdUsingRepoDI.Models;
using CurdUsingRepoDI.Reposiratories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<ClassContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("scon")));
builder.Services.AddScoped<EmpInterface, EmpRepo>();
builder.Services.AddScoped<DeptInterface,DeptRepo>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();
app.Run();
