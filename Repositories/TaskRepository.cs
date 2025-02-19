using OrderTaskApi.Models;

namespace OrderTaskApi.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly List<TaskItem> _tasks = new List<TaskItem>
        {
            new TaskItem { Id = 1, Title = "Review PR", IsCompleted = false },
            new TaskItem { Id = 2, Title = "Write Unit Tests", IsCompleted = false }
        };

        public IEnumerable<TaskItem> GetAll() => _tasks;

        public void Add(TaskItem task)
        {
            task.Id = _tasks.Count + 1;
            _tasks.Add(task);
        }
    }
}
