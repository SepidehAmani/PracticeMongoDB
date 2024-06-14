using MongoDB.Bson;
using Testing_MongoDB.Domain.DTOs;
using Testing_MongoDB.Domain.Entities;
using Testing_MongoDB.Repositories;

namespace Testing_MongoDB.Services;

public class BrandService : IBrandService
{
    private readonly IBrandRepository _brandRepository;
    public BrandService(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }


    public async Task CreateBrandAsync(CreateBrandDTO dto,CancellationToken cancellation)
    {
        var brandEntity = new Brand() { Name = dto.Name , Id = new ObjectId() };
        await _brandRepository.CreateAsync(brandEntity,cancellation);
    }
}
