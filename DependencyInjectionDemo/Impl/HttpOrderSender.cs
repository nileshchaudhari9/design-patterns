using System.Text;
using System.Text.Json;

namespace DependencyInjectionDemo;

public class HttpOrderSender : IOrderSender
{
    private static readonly HttpClient httpClient = new HttpClient();

    public async Task<string> Send(Order order)
    {
        var jsonOrder = JsonSerializer.Serialize<Order>(order);
        var stringContent = new StringContent(jsonOrder, UnicodeEncoding.UTF8, "application/json");

        //This statement calls a not existing URL. This is just an example...
        var response = await httpClient.PostAsync("https://mockend.com/org/repo/orders", stringContent);

        return response.Content.ReadAsStringAsync().Result;

    }
}