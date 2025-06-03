using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace XPTOProductService.DTOs
{
    public class GetProductRequest
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }
    }
}
