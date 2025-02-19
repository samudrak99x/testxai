using OrderTaskApi.Models;

namespace OrderTaskApi.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new List<Order>
        {
            new Order { Id = 1, CustomerName = "Alice", Amount = 100, CreatedAt = DateTime.UtcNow },
            new Order { Id = 2, CustomerName = "Bob", Amount = 200, CreatedAt = DateTime.UtcNow }
        };

        public IEnumerable<Order> GetAll() => _orders;

        public void Add(Order order)
        {
            order.Id = _orders.Count + 1;
            order.CreatedAt = DateTime.UtcNow;
            _orders.Add(order);
        }

        public void Delete(int id)
        {
            var order = _orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
                _orders.Remove(order);
        }
    }
}
