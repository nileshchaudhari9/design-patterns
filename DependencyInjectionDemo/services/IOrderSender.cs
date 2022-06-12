
namespace DependencyInjectionDemo;

public interface IOrderSender
{
    Task<string> Send(Order order);
}