using CleanArchitecture_NET6.Domain.Common;

namespace CleanArchitecture_NET6.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
