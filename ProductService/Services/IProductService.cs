using XPTOProductService.DTOs;
using XPTOProductService.Models;

namespace XPTOProductService.Services
{
    public interface IProductService
    {
        Task<Product> RegisterAsync(RegisterProductRequest request);
        Task<Product?> GetByIdAsync(Guid id);
    }
}
