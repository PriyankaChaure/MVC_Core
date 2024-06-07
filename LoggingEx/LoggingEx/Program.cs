using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();
builder.Host.UseNLog();
builder.Services.AddControllersWithViews();
var app = builder.Build();


app.MapDefaultControllerRoute();
app.Run();
