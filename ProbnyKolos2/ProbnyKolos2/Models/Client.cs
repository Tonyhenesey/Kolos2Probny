using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProbnyKolos2.Models;

[Table("client")]
public class Client
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;
    [MaxLength(120)]
    public string LastName { get; set; } = string.Empty;

    public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    
    
}