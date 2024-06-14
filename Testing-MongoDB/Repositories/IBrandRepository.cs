using MongoDB.Bson;
using Testing_MongoDB.Domain.Entities;

namespace Testing_MongoDB.Repositories;

public interface IBrandRepository
{
    Task<List<Brand>> GetAllAsync();

    Task<Brand> GetByIdAsync(ObjectId id);

    Task CreateAsync(Brand entity, CancellationToken cancellation);

    Task UpdateAsync(ObjectId id, Brand entityIn);

    Task RemoveAsync(ObjectId id);
}
