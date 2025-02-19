using Microsoft.AspNetCore.Mvc;
using OrderTaskApi.Models;
using OrderTaskApi.Repositories;

namespace OrderTaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public TasksController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_taskRepository.GetAll());

        [HttpPost]
        public IActionResult Create([FromBody] TaskItem task)
        {
            _taskRepository.Add(task);
            return CreatedAtAction(nameof(GetAll), new { id = task.Id }, task);
        }
    }
}
