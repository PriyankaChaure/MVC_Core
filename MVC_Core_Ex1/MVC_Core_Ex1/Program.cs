using Microsoft.EntityFrameworkCore;
using MVC_Core_Ex1.Models;
using MVC_Core_Ex1.Reposiratories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<ClassContext>(opt => opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("scon")));
builder.Services.AddScoped<FlightFacilityInterface, FlightFacilityRepo>();
builder.Services.AddScoped<FlightsInterface, FlightRepo>();
builder.Services.AddScoped<CityInterface, CityRepo>();
builder.Services.AddScoped<FacilityInterface, facilityRepo>();
builder.Services.AddScoped<FlightVMInterface, FlightVMRepo>();  


var app = builder.Build();
app.UseStaticFiles();

app.MapDefaultControllerRoute();
app.Run();
