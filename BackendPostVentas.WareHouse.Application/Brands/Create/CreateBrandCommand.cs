namespace BackendPostVentas.WareHouse.Application.Brands.Create
{
    public record CreateBrandCommand(
        string Name,
        string Description
    ) : IRequest<ErrorOr<Unit>>;
}
