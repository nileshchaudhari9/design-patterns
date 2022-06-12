namespace AbstractFactoryDemo;

public class Client
{   
    public void Main() 
    {
        Console.WriteLine("Client: Testing client code with the first factory type...");
        ClientMethod(new Factory());
    }

    private void ClientMethod(IAbstractFactory factory) 
    {
        var prodA = factory.CreateProductA();
        var prodB = factory.CreateProductB();

        Console.WriteLine(prodA.UsefulFunctionA());

        Console.WriteLine(prodB.UsefulFunctionB());

        Console.WriteLine(prodB.AnotherUsefulFunctionB(prodA));
    }
}
