using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Testing_MongoDB.Domain.Entities;

public class Brand
{
    //[BsonId]
    //[BsonRepresentation(BsonType.ObjectId)]
    public ObjectId Id { get; set; }
    public string Name { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.Now;
}
