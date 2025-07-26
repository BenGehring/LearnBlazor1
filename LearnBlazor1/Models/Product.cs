namespace LearnBlazor1.Models;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }

    public bool IsActive { get; set; }

    public IEnumerable<ProductProperty> ProductProperties { get; set; } = [];
}
