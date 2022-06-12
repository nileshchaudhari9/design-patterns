using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionDemo;

public class Client
{
    private static IServiceProvider? serviceProvider = null;

    public async Task Main() {
        ConfigureServices();

        var orderManager = serviceProvider?.GetService<IOrderManager>();
        var order = CreateOrder();
        
        if (orderManager is not null){
            var response = await orderManager.Transmit(order);
            Console.WriteLine(response ?? "No response");
        }
        return;
    }

    private static void ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddTransient<IOrderManager, OrderManager>();
        services.AddSingleton<IOrderSender, HttpOrderSender>();

        serviceProvider = services.BuildServiceProvider();
    }

    private static Order CreateOrder()
    {
        return new Order
        {
            CustomerId = "12345",
            Date = new DateTime(),
            TotalAmount = 145,
            Items = new System.Collections.Generic.List<OrderItem>
                {
                    new OrderItem {
                        ItemId = "99999",
                        Quantity = 1,
                        Price = 145
                    }
                }
        };
    }
}
