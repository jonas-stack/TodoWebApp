namespace TodoApp.Api.GraphQl.Types;

public class TodoType
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
}