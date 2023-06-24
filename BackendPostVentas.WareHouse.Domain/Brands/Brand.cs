

namespace BackendPostVentas.WareHouse.Domain.Brands
{
    public sealed class Brand : BaseEntity
    {
        public BrandId Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public bool IsActive { get; private set; } = true;

        public Brand(BrandId id, string name, string description, bool isActive)
        {
            Id = id;
            Name = name;
            Description = description;
            IsActive = isActive;
        }

        private Brand()
        {
            
        }

        
    }

}