namespace BackendPostVentas.WareHouse.Domain.Brands
{
    public interface IBrandRepository
    {
        Task<Brand?> GetByIdAsync(BrandId id);
        Task Add(Brand brand);
    }
}
    
