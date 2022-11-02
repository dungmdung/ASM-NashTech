using Microsoft.AspNetCore.Mvc;
using Assignment8.Models;

namespace Assignment8.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    private readonly ILogger<TasksController> _logger;

    public TasksController(ILogger<TasksController> logger)
    {
        _logger = logger;
    }

    private static readonly List<NewTaskModel> taskList = new()
    {
        new NewTaskModel("First Task", true),
        new NewTaskModel("Second Task", false),
        new NewTaskModel("Third Task", true)
    };

    [HttpPost]
    public ActionResult<NewTaskModel> Create([FromBody] CreateTaskModel createModel)
    {
        if (createModel != null)
        {
            var newTask = new NewTaskModel(createModel.Title, false);
            taskList.Add(newTask);
            return CreatedAtRoute(new { id = newTask.Id.ToString() }, newTask);
        }
        return BadRequest();
    }

    [HttpGet]
    public ActionResult<IEnumerable<NewTaskModel>> GetAll()
    {
        return Ok(taskList);
    }

    [HttpGet("{id}")]
    public ActionResult<NewTaskModel> GetTaskById(Guid id)
    {
        var obj = taskList.Find(obj => obj.Id == id);

        if (obj != null)
        {
            return Ok(obj);
        }

        return NotFound();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(Guid id)
    {
        var obj = taskList.Find(obj => obj.Id == id);

        if (obj != null)
        {
            taskList.Remove(obj);
            return Ok();
        }

        return NotFound();
    }

    [HttpPost("Make-multiple")]
    public ActionResult<IEnumerable<NewTaskModel>> CreateManyTask([FromBody] List<CreateTaskModel> createModels)
    {
        if (createModels != null)
        {
            var newTasks = createModels.ConvertAll(task => new NewTaskModel(task.Title, false));
            taskList.AddRange(newTasks);
            return Ok(newTasks);
        }

        return BadRequest();
    }
}