using OrderTaskApi.Models;

namespace OrderTaskApi.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<TaskItem> GetAll();
        void Add(TaskItem task);
    }
}
