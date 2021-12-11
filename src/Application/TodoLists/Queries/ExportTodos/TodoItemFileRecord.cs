using CleanArchitecture_NET6.Application.Common.Mappings;
using CleanArchitecture_NET6.Domain.Entities;

namespace CleanArchitecture_NET6.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
