using WebApplicationASP1.Services;
using WebApplicationASP1.Settings;

var builder = WebApplication.CreateBuilder(args);

// Bind MongoDB settings from appsettings.json
builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));

// Register ProductService as a singleton — MongoClient is thread-safe
// and meant to be reused for the lifetime of the application
builder.Services.AddSingleton<ProductService>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", () => "Hello!");
app.Run();
