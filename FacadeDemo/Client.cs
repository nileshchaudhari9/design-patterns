namespace FacadeDemo;
public class Client
{
    public static void ClientCode()
    {
        var facade = new Facade(new Subsystem1(), new Subsystem2());
        Console.Write(facade.Operation());
    }
}
