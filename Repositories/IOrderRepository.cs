using OrderTaskApi.Models;

namespace OrderTaskApi.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        void Add(Order order);
        void Delete(int id);
    }
}
