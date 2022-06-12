namespace DependencyInjectionDemo;

public class Order
{
    public string CustomerId { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public decimal TotalAmount { get; set; }
    public List<OrderItem> Items { get; set; }

    public Order()
    {
        Items = new List<OrderItem>();
    }
}

public class OrderItem
{
    public string ItemId { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }
}