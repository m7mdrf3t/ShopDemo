namespace AppDemo.Core.Entities;
public class Product
{
    public int Id { get; set; }
    public string ProductName { set; get; } = null!;
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public string ImgUrl { get; set; } = null!;
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
}

