using MongoDB.Bson;
using MongoDB.Driver;
using XPTOProductService.Repositories;
using XPTOProductService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<IMongoClient>(sp =>
//{
//    var logger = sp.GetRequiredService<ILoggerFactory>().CreateLogger("MongoClientInitialization");
//    var connectionString = builder.Configuration.GetValue<string>("MongoDb:ConnectionString")
//                           ?? "mongodb://localhost:27017";
//    try
//    {
//        var client = new MongoClient(connectionString);
//        // Health check ping
//        var database = client.GetDatabase("admin");
//        database.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait();
//        logger.LogInformation("✅ Successfully connected to MongoDB.");
//        return client;
//    }
//    catch (Exception ex)
//    {
//        logger.LogError(ex, "❌ Failed to connect to MongoDB.");
//        throw;
//    }
//});

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IMongoClient, MongoClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
