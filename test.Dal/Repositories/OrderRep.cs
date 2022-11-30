using Microsoft.EntityFrameworkCore;
using test.Dal.Interfaces;
using test.Domain.Models;

namespace test.Dal.Repositories
{
    public class OrderRep : IOrderRep
    {
        private readonly ApplicationDbContext _db;

        public OrderRep(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(string Description)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order>> Select()
        {
            return await _db.Order.ToListAsync();
        }
    }
}
