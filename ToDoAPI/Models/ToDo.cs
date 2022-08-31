using ToDoAPI.Models.Enums;

namespace ToDoAPI.Models;

public class ToDo
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid Id { get; set; }
    public StatusEnum StatusEnum { get; set; }
}

