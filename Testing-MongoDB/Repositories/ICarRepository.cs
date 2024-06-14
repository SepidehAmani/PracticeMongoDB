using MongoDB.Bson;
using Testing_MongoDB.Domain.Entities;

namespace Testing_MongoDB.Repositories;

public interface ICarRepository
{
    Task<List<Car>> GetAllAsync();

    Task<Car> GetByIdAsync(ObjectId id);

    Task CreateAsync(Car entity, CancellationToken cancellation);

    Task UpdateAsync(ObjectId id, Car entityIn);

    Task RemoveAsync(ObjectId id);
}
