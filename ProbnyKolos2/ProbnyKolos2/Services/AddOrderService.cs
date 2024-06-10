using ProbnyKolos2.DTO;
using ProbnyKolos2.Models;

namespace ProbnyKolos2.Repository;

public class AddOrderService : IAddOrderService
{
    private readonly ApplicationDbContext _context;

    public AddOrderService(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentException(nameof(context));

    }

 
    public async Task AddOrderAsync(AddOrderDto addOrder)
    {
        var order = new Order
        {
            AcceptedAt = addOrder.AcceptedAt,
            FulfilledAt = addOrder.FulfilledAt,
            Comments = addOrder.Comments,
            EmployeeId = addOrder.EmployeeId,
            ClientId = addOrder.ClientId,
            OrderPastries = addOrder.Pastries.Select(p => new OrderPastry
            {
                PastryId = p.PastryId,
                Amount = p.Amount,
                Comment = p.Comments
            }).ToList()
        };

        _context.Orders.Add(order);
        await _context.SaveChangesAsync();
    }

}