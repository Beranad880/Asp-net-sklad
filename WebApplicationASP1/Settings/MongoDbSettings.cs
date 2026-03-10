namespace WebApplicationASP1.Settings;

public sealed class MongoDbSettings
{
    public string ConnectionString { get; set; } = string.Empty;
    public string DatabaseName { get; set; } = string.Empty;
    public string ProductsCollectionName { get; set; } = string.Empty;
}
