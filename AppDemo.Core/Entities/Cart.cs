using System;
namespace AppDemo.Core.Entities;
public class Cart
{
    public int Id { get; set; }
    public int Count { get; set; }
    public int CustomerId { get; set; }
    public IEnumerable<Product>? Products { get; set; }
    public Customer Customer { get; set; } = null!;
}

