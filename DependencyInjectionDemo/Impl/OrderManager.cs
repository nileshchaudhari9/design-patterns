namespace DependencyInjectionDemo;

public class OrderManager : IOrderManager
{
    private IOrderSender orderSender;

    public OrderManager(IOrderSender sender)
    {
        orderSender = sender;
    }

    public async Task<string> Transmit(Order order)
    {
        return await orderSender.Send(order);
    }
}