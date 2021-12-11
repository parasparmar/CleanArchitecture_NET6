using CleanArchitecture_NET6.Application.Common.Interfaces;

namespace CleanArchitecture_NET6.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
