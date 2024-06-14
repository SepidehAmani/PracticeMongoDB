using Testing_MongoDB.Domain.DTOs;

namespace Testing_MongoDB.Services;

public interface IBrandService
{
    Task CreateBrandAsync(CreateBrandDTO dto, CancellationToken cancellation);
}
