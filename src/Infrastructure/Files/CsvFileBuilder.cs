using System.Globalization;
using CleanArchitecture_NET6.Application.Common.Interfaces;
using CleanArchitecture_NET6.Application.TodoLists.Queries.ExportTodos;
using CleanArchitecture_NET6.Infrastructure.Files.Maps;
using CsvHelper;

namespace CleanArchitecture_NET6.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
