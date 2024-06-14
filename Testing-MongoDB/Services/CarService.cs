using MongoDB.Bson;
using Testing_MongoDB.Domain.DTOs;
using Testing_MongoDB.Domain.Entities;
using Testing_MongoDB.Repositories;

namespace Testing_MongoDB.Services;

public class CarService : ICarService
{
    private readonly ICarRepository _carRepository;
    private readonly IBrandRepository _brandRepository;
    public CarService(ICarRepository carRepository, IBrandRepository brandRepository)
    {
        _carRepository = carRepository;
        _brandRepository = brandRepository;
    }


    public async Task<bool> CreateCar(CreateCarDTO dto,CancellationToken cancellation)
    {
        var brand = await _brandRepository.GetByIdAsync(new ObjectId(dto.BrandId));
        if (brand == null) return false;

        var carEntity = new Car() { Id = new ObjectId(), Model = dto.Model, Brand = brand };
        await _carRepository.CreateAsync(carEntity, cancellation);
        return true;
    }
}
