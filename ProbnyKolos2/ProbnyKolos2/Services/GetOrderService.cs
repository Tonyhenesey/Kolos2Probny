using Microsoft.EntityFrameworkCore;
using ProbnyKolos2.Models;

namespace ProbnyKolos2.Repository;

public class GetOrderService : IGetOrderService
{
    private readonly ApplicationDbContext _context;

    public GetOrderService(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentException(nameof(context));
    }
    public async Task<ICollection<Order>> GetOrdersData(string? clientLastName)
    {
        return await _context.Orders
            .Include(e => e.Client)
            .Include(e => e.OrderPastries)
            .ThenInclude(e => e.Pastry)
            .Where(e => clientLastName == null || e.Client.LastName == clientLastName)
            .ToListAsync();
    }
}