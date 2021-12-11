using CleanArchitecture_NET6.Application.TodoLists.Queries.ExportTodos;

namespace CleanArchitecture_NET6.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
