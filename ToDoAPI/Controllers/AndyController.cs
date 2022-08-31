using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Models;
using ToDoAPI.Models.Enums;
using ToDoAPI.Services;

namespace ToDoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AndyController : ControllerBase
{
    

    private readonly ILogger<AndyController> _logger;

    public AndyController(ILogger<AndyController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAll")]
    public IEnumerable<ToDo> Get()
    {
        var toDoService = new ToDoService();
        return toDoService.GetAll();
    }
    [HttpPost(Name = "Create")]
    public ToDo Create(string title, string description)
    {
        var toDoService = new ToDoService();
        return toDoService.Create(title, description);
    }
    [HttpDelete(Name = "Delete")]
    public void Delete(Guid id)
    {
        var toDoService = new ToDoService();
        toDoService.Delete(id);
    }
    [HttpPatch(Name = "Complete")]
    public void Complete(Guid id)
    {
        var toDoService = new ToDoService();
        toDoService.Complete(id);
    }
}