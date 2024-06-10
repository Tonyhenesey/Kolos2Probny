using Microsoft.AspNetCore.Mvc;
using ProbnyKolos2.Repository;

namespace ProbnyKolos2.Controllers;


[Route("api/[controller]")]
[ApiController]
public class GetOrderController : ControllerBase
{
    private readonly IGetOrderService _getOrderService;

    public GetOrderController(IGetOrderService orderService)
    {
        _getOrderService = orderService;
    }

    [HttpGet]
    public async Task<IActionResult> GetOrders(String clientName)
    {
        var orders = await _getOrderService.GetOrdersData(clientName);
        return Ok(orders);
    }

}