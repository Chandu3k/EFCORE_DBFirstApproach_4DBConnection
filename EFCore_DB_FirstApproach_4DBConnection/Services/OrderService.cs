using EFCore_DB_FirstApproach_4DBConnection.Dtos;
using EFCore_DB_FirstApproach_4DBConnection.Interfaces;
using EFCore_DB_FirstApproach_4DBConnection.MidlandModels;

namespace EFCore_DB_FirstApproach_4DBConnection.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }   

        public async Task<bool> AddOrder(OrderDto orderdetails)
        {
            Order ord = new Order();
            ord.Orderid= orderdetails.Orderid;
            ord.Ordername=orderdetails.Ordername;
            ord.Orderlocation=orderdetails.Orderlocation;
            var result = await _orderRepository.AddOrder(ord);
            return result;

        }

        public async Task<bool> DeleteOrderById(int orderid)
        {
            await _orderRepository.DeleteOrderById(orderid);
            return true;
        }

        public async Task<List<OrderDto>> GetAllOrders()
        {
            List<OrderDto> lstorderdto=new List<OrderDto>();
            var orders = await _orderRepository.GetAllOrders();
            foreach (var ord in orders)
            {
                OrderDto ordDto = new OrderDto();
                ordDto.Orderid = ord.Orderid;
                ordDto.Ordername = ord.Ordername;
                ordDto.Orderlocation = ord.Orderlocation;
                lstorderdto.Add(ordDto);
            }
            return lstorderdto;
        }

        public async Task<OrderDto> GetOrdersById(int orderid)
        {
            var result= await _orderRepository.GetOrdersById(orderid);
            OrderDto ord=new OrderDto();
            ord.Orderid= result.Orderid;
            ord.Ordername=result.Ordername;
            ord.Orderlocation=result.Orderlocation;
            return ord;
        }

        public Task<bool> UpdateOrder(OrderDto orderdetails)
        {
            Order ord=new Order();
            ord.Orderid = orderdetails.Orderid;
            ord.Ordername = orderdetails.Ordername;
            ord.Orderlocation = orderdetails.Orderlocation;
            var result = _orderRepository.UpdateOrder(ord);
            return result;
        }
    }
}
