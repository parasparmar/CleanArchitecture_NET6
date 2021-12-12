using System.Globalization;
using CleanArchitecture_NET6.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace CleanArchitecture_NET6.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done ? "Yes" : "No");
            
            //.ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
