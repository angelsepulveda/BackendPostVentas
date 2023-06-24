namespace BackendPostVentas.WareHouse.Infrastructure.Brands.Persistence.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        public readonly ApplicationDbContext _context;

        public BrandRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task Add(Brand brand) => await _context.Brands.AddAsync(brand);

        public async Task<Brand?> GetByIdAsync(BrandId id) => await _context.Brands.SingleOrDefaultAsync(c => c.Id == id);
    }
}
