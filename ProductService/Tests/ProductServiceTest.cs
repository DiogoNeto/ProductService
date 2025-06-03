using Moq;
using XPTOProductService.DTOs;
using XPTOProductService.Repositories;
using XPTOProductService.Services;
using Xunit;

namespace XPTOProductService.Tests
{
    public class ProductServiceTest
    {
        [Fact]
        public async Task RegisterAsync_ShouldCreateProductWithValidData()
        {
            var mockRepository = new Mock<IProductRepository>();
            var service = new ProductService(mockRepository.Object);

            var request = new RegisterProductRequest
            {
                Description = "Test Product",
                Categories = new List<CategoryDto>
            {
                new CategoryDto { Id = Guid.NewGuid(), Name = "Cat 1" }
            },
                Stock = 10,
                Price = "10.5"
            };

            var result = await service.RegisterAsync(request);

            Assert.Equal("Test Product", result.Description);
            Assert.Single(result.Categories);
            Assert.Equal(10, result.Stock);
            Assert.Equal(10.5f, result.Price);
        }
    }
}
