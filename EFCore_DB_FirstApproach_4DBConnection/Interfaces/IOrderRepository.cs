using EFCore_DB_FirstApproach_4DBConnection.MidlandModels;

namespace EFCore_DB_FirstApproach_4DBConnection.Interfaces
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrders();
        Task<Order> GetOrdersById(int orderid);
        Task<bool> DeleteOrderById(int orderid);
        Task<bool> AddOrder(Order orderdetails);
        Task<bool> UpdateOrder(Order orderdetails);


    }
}
