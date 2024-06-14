using MongoDB.Bson;

namespace Testing_MongoDB.Domain.Entities
{
    public class Car
    {
        public ObjectId Id { get; set; }
        public string Model { get; set; }
        public Brand Brand { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
