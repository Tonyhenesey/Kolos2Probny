using Microsoft.AspNetCore.Mvc;
using ProbnyKolos2.DTO;
using ProbnyKolos2.Repository;
using System.Threading.Tasks;

namespace ProbnyKolos2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddOrderController : ControllerBase
    {
        private readonly IAddOrderService _addOrderService;

        public AddOrderController(IAddOrderService addOrderService)
        {
            _addOrderService = addOrderService;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody] AddOrderDto orderDto)
        {
            await _addOrderService.AddOrderAsync(orderDto);
            return Ok();
        }
    }
}