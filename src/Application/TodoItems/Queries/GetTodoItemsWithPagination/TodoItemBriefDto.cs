using CleanArchitecture_NET6.Application.Common.Mappings;
using CleanArchitecture_NET6.Domain.Entities;

namespace CleanArchitecture_NET6.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}
