namespace GenericFactory;
public class Client
{
    public void Main() 
    {   
        var product = new ProductFactory().Create();
        product.DoWork();
    }
}
