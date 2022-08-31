using ToDoAPI.Models;
using ToDoAPI.Models.Enums;

namespace ToDoAPI.Services;

public class ToDoService
{
    private static readonly List<ToDo> _imdb = new List<ToDo>();
    public IEnumerable<ToDo> GetAll()
    {
        return _imdb;
    }

    public ToDo Create(string title, string description)
    {
        var toDoToCreate = new ToDo()
        {
            Title = title, Description = description, Id = Guid.NewGuid(), StatusEnum = StatusEnum.InProgress
        };
        
        _imdb.Add(toDoToCreate);

        return toDoToCreate;
    }

    public void Delete(Guid id)
    {
        _imdb.RemoveAt(_imdb.FindIndex(i => i.Id == id));
    }

    public void Complete(Guid id)
    {
        var toDo = _imdb.Find(i => i.Id == id);
        toDo.StatusEnum = StatusEnum.Completed;
    }
        
    
}

