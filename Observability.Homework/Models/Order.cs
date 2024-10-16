namespace Observability.Homework.Models;

public class Order
{
    public required Client Client { get; set; }
    
    public required Product Product { get; set; }
}