using EFCore_DB_FirstApproach_4DBConnection.Dtos;

namespace EFCore_DB_FirstApproach_4DBConnection.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderDto>> GetAllOrders();
        Task<OrderDto> GetOrdersById(int orderid);
        Task<bool> DeleteOrderById(int orderid);
        Task<bool> AddOrder(OrderDto orderdetails);
        Task<bool> UpdateOrder(OrderDto orderdetails);
    }
}
