using BackendPostVentas.WareHouse.Domain.Brands;
using Microsoft.EntityFrameworkCore;

namespace BackendPostVentas.Shared.Application.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Brand> Brands { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
     }
}
