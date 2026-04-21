using EFCore_DB_FirstApproach_4DBConnection.Interfaces;
using EFCore_DB_FirstApproach_4DBConnection.MidlandModels;
using Microsoft.EntityFrameworkCore;

namespace EFCore_DB_FirstApproach_4DBConnection.Repository
{ 
    public class OrderRepository : IOrderRepository
    {
        private readonly MidlandContext _context;
        public OrderRepository(MidlandContext context)
        {
            _context = context;
        }

        public async Task<bool> AddOrder(Order orderdetails)
        {
            await _context.Orders.AddAsync(orderdetails);
            _context.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteOrderById(int orderid)
        {
            var result = await _context.Orders.Where(a=>a.Orderid==orderid).FirstOrDefaultAsync();
            if (result != null)
            {
                _context.Orders.Remove(result);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Order>> GetAllOrders()
        {
            var result = await _context.Orders.ToListAsync();
            if (result.Count == 0)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public Task<Order> GetOrdersById(int orderid)
        {
            var result = _context.Orders.Where(a => a.Orderid == orderid).FirstOrDefaultAsync();
            if (result == null)
            {
                return null;

            }
            else
            {
                return result;
            }
        }

        public async Task<bool> UpdateOrder(Order orderdetails)
        {
            _context.Orders.Update(orderdetails);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
