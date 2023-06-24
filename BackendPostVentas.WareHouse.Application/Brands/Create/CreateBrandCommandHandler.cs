namespace BackendPostVentas.WareHouse.Application.Brands.Create
{
    internal sealed class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, Unit>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateBrandCommandHandler(
            IBrandRepository brandRepository,
            IUnitOfWork unitOfWork)
        {
            _brandRepository = brandRepository ?? throw new ArgumentNullException(nameof(brandRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

       
        public async Task<Unit> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = new Brand(
                new BrandId(Guid.NewGuid()),
                request.Name,
                request.Description,
                true);

            await _brandRepository.Add(brand);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
        
