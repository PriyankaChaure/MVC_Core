var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var app = builder.Build();

if(app.Environment.IsDevelopment() || app.Environment.IsStaging () )
{
    app.UseDeveloperExceptionPage();
}
else if(app.Environment.IsProduction ())
{
    app.UseExceptionHandler("/CustomeError");
}
//app.MapControllers();
app.MapDefaultControllerRoute();
app.Run();
