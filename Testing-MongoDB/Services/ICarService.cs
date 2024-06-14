using Testing_MongoDB.Domain.DTOs;

namespace Testing_MongoDB.Services;

public interface ICarService
{
    Task<bool> CreateCar(CreateCarDTO dto, CancellationToken cancellation);
}
