using XPTOProductService.DTOs;
using XPTOProductService.Models;
using XPTOProductService.Repositories;

namespace XPTOProductService.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> RegisterAsync(RegisterProductRequest request)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Description = request.Description,
                Categories = request.Categories.Select(c => c.Id).ToList(),
                Stock = request.Stock,
                Price = float.TryParse(request.Price, out var p) ? p : 0
            };

            await _repository.AddAsync(product);
            return product;
        }

        public async Task<Product?> GetByIdAsync(Guid id) =>
            await _repository.GetByIdAsync(id);
    }
}
