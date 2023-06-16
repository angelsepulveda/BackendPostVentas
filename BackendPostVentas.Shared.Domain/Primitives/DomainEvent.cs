using MediatR;

namespace BackendPostVentas.Shared.Domain.Primitives
{
    public record DomainEvent(Guid Id): INotification;
 }
