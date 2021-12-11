using CleanArchitecture_NET6.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture_NET6.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
