namespace GenericFactory;


internal class Product : IProduct
{
    public void DoWork() => Console.WriteLine("Product works");
}