using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace XPTOProductService.DTOs
{
    public class CategoryDto
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
