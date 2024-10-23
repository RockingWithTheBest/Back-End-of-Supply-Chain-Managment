using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SupplyChain.Data_Transfer_Object_DTOs_;
using xx1.Db;
using xx1.Repository.Interface;

namespace SupplyChain.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]/")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IOrder _iorder;
        private readonly IMapper mapper;
        public OrderController(ApplicationDBContext dbContext, IOrder order, IMapper imap)
        {
            _dbContext = dbContext;
            _iorder = order;
            mapper = imap;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("IndexingAll")]
        public IActionResult GetAll() 
        { 
            var orders = _iorder.GetAllOrders();
            if(orders == null)
            {
                return NotFound("Not Orders exist");
            }
            //var orderDto = mapper.Map<IEnumerable<OrderDto>>(orders);
            return Ok(orders);
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetById")]
        public IActionResult GetByid(int id)
        {
            var order = _iorder.GetOrderById(id);
            if(order == null)
            {
                return NotFound($"Order of id - {id} doesnt exist");
            }
            return Ok(order);
        }

    }
}
