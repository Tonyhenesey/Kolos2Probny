namespace ProbnyKolos2.DTO;

public class AddOrderDto
{
    public int ClientId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime AcceptedAt { get; set; }
    public DateTime? FulfilledAt { get; set; }
    public string Comments { get; set; }
    public ICollection<AddOrderPastryDto> Pastries { get; set; }
}

public class AddOrderPastryDto
{
    public int PastryId { get; set; }
    public int Amount { get; set; }
    public string Comments { get; set; }
}