using Microsoft.AspNetCore.Mvc;
using Moq;
using XPTO.ProductService.Controllers;
using XPTOProductService.Models;
using XPTOProductService.Services;

namespace XPTOProductService.Tests
{
    public class ProductServiceTest
    {
        private readonly Mock<IProductService> _mockService;
        private readonly ProductController _controller;

        public ProductServiceTest()
        {
            _mockService = new Mock<IProductService>();
            _controller = new ProductController(_mockService.Object);
        }

        [Fact]
        public async Task Get_ProductExists_ReturnsOkWithProduct()
        {
            // Arrange
            var productId = Guid.NewGuid();
            var product = new Product
            {
                Id = productId,
                Description = "Test Product",
                Stock = 10,
                Price = 10.5f
            };

            _mockService.Setup(s => s.GetByIdAsync(productId))
                .ReturnsAsync(product);

            // Act
            var result = await _controller.Get(productId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedProduct = Assert.IsType<Product>(okResult.Value);
            Assert.Equal(productId, returnedProduct.Id);
            Assert.Equal(10, returnedProduct.Stock);
            Assert.Equal("Test Product", returnedProduct.Description);
        }

        [Fact]
        public async Task Get_ProductDoesNotExist_ReturnsNotFound()
        {
            // Arrange
            var productId = Guid.NewGuid();
            _mockService.Setup(s => s.GetByIdAsync(productId))
                .ReturnsAsync((Product)null);

            // Act
            var result = await _controller.Get(productId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
