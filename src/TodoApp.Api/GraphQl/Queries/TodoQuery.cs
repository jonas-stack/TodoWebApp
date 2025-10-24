using TodoApp.Api.GraphQl.Types;

namespace TodoApp.Api.GraphQl.Queries;

public class TodoQuery
{
    public TodoType GetTodo() =>
        new TodoType
        {
            Title = "Sample Todo",
            Description = "This is a sample todo item.",
            IsCompleted = false
        };
}