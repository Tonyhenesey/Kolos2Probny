namespace ProbnyKolos2.DTO;

public class GetOrdersDto
{
    public int Id { get; set; }
    public DateTime AcceptedAt { get; set; }
    public DateTime? FulfilledAt { get; set; }
    public String? Comments { get; set; }
    public ICollection<GetOrdersPastryDto> Pastries { get; set; }
}

public class GetOrdersPastryDto
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Amount { get; set; }
}