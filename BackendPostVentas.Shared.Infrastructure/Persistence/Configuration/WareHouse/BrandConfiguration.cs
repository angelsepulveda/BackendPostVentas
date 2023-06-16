using BackendPostVentas.WareHouse.Domain.Brands;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackendPostVentas.Shared.Infrastructure.Persistence.Configuration.WareHouse
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");
            
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasConversion(
                   brandId => brandId.Value,
                   value => new BrandId(value));
        
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
            
            builder.Property(p => p.Description).HasMaxLength(256);
            
            builder.Property(p => p.IsActive).IsRequired();
        }
    }
}
