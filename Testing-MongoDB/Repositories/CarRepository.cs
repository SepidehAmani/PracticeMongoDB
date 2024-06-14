using MongoDB.Bson;
using MongoDB.Driver;
using Testing_MongoDB.Domain.Entities;

namespace Testing_MongoDB.Repositories;

public class CarRepository : ICarRepository
{
    private readonly IMongoCollection<Car> Cars;

    public CarRepository(IMongoDatabase database)
    {
        Cars = database.GetCollection<Car>("Cars");
    }

    public async Task<List<Car>> GetAllAsync()
    {
        return await Cars.Find(entity => true).ToListAsync();
    }

    public async Task<Car> GetByIdAsync(ObjectId id)
    {
        return await Cars.Find<Car>(entity => entity.Id == id).FirstOrDefaultAsync();
    }

    public async Task CreateAsync(Car entity, CancellationToken cancellation)
    {
        await Cars.InsertOneAsync(entity);
    }

    public async Task UpdateAsync(ObjectId id, Car entityIn)
    {
        await Cars.ReplaceOneAsync(entity => entity.Id == id, entityIn);
    }

    public async Task RemoveAsync(ObjectId id)
    {
        await Cars.DeleteOneAsync(entity => entity.Id == id);
    }
}
