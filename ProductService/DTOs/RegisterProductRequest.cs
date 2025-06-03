namespace XPTOProductService.DTOs
{
    public class RegisterProductRequest
    {
        public string Description { get; set; }
        public List<CategoryDto> Categories { get; set; }
        public int Stock { get; set; }
        public string Price { get; set; }
    }
}
