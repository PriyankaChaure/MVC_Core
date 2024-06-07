using ExamCore.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<ContextClass>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("scon")));
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();
app.Run();
