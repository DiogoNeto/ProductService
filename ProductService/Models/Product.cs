using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace XPTOProductService.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        [BsonRepresentation(BsonType.String)]
        public List<Guid> Categories { get; set; }
        public float Price { get; set; }
    }
}
