namespace AppDemo.Core.Entities;

public class Customer
{
    public int Id { get; set; }
    public string CustomerName { get; set; }=null!;
    public string Address { get; set; } = null!;
    public int CartId { get; set; }
    public Cart? Cart { get; set; }
    public IEnumerable<Product>? Products { get; set; }
}