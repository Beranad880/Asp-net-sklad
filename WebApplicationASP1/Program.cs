var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Use(async (context, next) =>
{

    Console.WriteLine("Request začal");

    await next(); 

    Console.WriteLine("Response se vrací");

}); ;
app.MapGet("/", () => "Hello World!");

app.Run();
