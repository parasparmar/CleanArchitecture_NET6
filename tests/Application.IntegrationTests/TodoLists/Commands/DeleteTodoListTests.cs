using CleanArchitecture_NET6.Application.Common.Exceptions;
using CleanArchitecture_NET6.Application.TodoLists.Commands.CreateTodoList;
using CleanArchitecture_NET6.Application.TodoLists.Commands.DeleteTodoList;
using CleanArchitecture_NET6.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace CleanArchitecture_NET6.Application.IntegrationTests.TodoLists.Commands;

using static Testing;

public class DeleteTodoListTests : TestBase
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand { Id = 99 };
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand
        {
            Id = listId
        });

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
