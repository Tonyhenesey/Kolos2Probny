using System.Threading.Tasks;
using ProbnyKolos2.DTO;

namespace ProbnyKolos2.Repository
{
    public interface IAddOrderService
    {
        Task AddOrderAsync(AddOrderDto addOrder);
    }
}