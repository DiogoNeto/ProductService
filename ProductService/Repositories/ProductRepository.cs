using MongoDB.Driver;
using XPTOProductService.Models;

namespace XPTOProductService.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMongoCollection<Product> _collection;

        public ProductRepository(IMongoClient client)
        {
            var db = client.GetDatabase("ProductDb");
            _collection = db.GetCollection<Product>("Products");
        }

        public async Task AddAsync(Product product) =>
            await _collection.InsertOneAsync(product);

        public async Task<Product?> GetByIdAsync(Guid id) =>
            await _collection.Find(p => p.Id == id).FirstOrDefaultAsync();
    }
}

