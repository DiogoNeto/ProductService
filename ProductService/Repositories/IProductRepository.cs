using XPTOProductService.Models;

namespace XPTOProductService.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<Product?> GetByIdAsync(Guid id);
    }
}
