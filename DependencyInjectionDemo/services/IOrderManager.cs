namespace DependencyInjectionDemo;

public interface IOrderManager
{
    public Task<string> Transmit(Order order);
}
