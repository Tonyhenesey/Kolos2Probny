using ProbnyKolos2.Models;

namespace ProbnyKolos2.Repository;

public interface IGetOrderService
{
    Task<ICollection<Order>> GetOrdersData(string? clientLastName);
}