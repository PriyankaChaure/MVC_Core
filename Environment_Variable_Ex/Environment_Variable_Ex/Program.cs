var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.MapGet("/",()=>"your application running in development mode!");
}
if(app.Environment.IsStaging())
{
    app.MapGet("/", () => "your application is running in staging mode!");
}
if (app.Environment.IsProduction())
{
    app.MapGet("/", () => "your application is running in production mode!");
}
else if(app.Environment.IsEnvironment("PC"))
{
    app.MapGet("/", () => "your application is running in PC mode!");
}
app.Run();
