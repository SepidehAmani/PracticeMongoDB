using MongoDB.Bson;
using MongoDB.Driver;
using Testing_MongoDB.Domain.Entities;

namespace Testing_MongoDB.Repositories;

public class BrandRepository : IBrandRepository
{
    private readonly IMongoCollection<Brand> Brands;

    public BrandRepository(IMongoDatabase database)
    {
        Brands = database.GetCollection<Brand>("Brands");
    }

    public async Task<List<Brand>> GetAllAsync()
    {
        return await Brands.Find(entity => true).ToListAsync();
    }

    public async Task<Brand> GetByIdAsync(ObjectId id)
    {
        return await Brands.Find<Brand>(entity => entity.Id == id).FirstOrDefaultAsync();
    }

    public async Task CreateAsync(Brand entity, CancellationToken cancellation)
    {
        await Brands.InsertOneAsync(entity);
    }

    public async Task UpdateAsync(ObjectId id, Brand entityIn)
    {
        await Brands.ReplaceOneAsync(entity => entity.Id == id, entityIn);
    }

    public async Task RemoveAsync(ObjectId id)
    {
        await Brands.DeleteOneAsync(entity => entity.Id == id);
    }
}
