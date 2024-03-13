using Grpc.Core;
using grpc_server_todo;

namespace grpc_server_todo.Services;

public class TodoItemsService : TodoItems.TodoItemsBase
{
    private readonly ILogger<TodoItemsService> _logger;
    public TodoItemsService(ILogger<TodoItemsService> logger)
    {
        _logger = logger;
    }

    public override Task<ListReply> GetList(ListRequest request, ServerCallContext context)
    {
        if (request.OnlyOpen) {
            return Task.FromResult(new ListReply
            {
                Items = {new List<string>(["Bla", "Blubb"])}
            });
        }
        return Task.FromResult(new ListReply
        {
            Items = {new List<string>(["Foo", "Bar"])}
        });
    }
}
