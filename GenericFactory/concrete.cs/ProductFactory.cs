namespace GenericFactory;


internal class ProductFactory: IFactory<IProduct>
{
    public IProduct Create() => new Product();
    
}

internal class CarFactory<T> : IFactory<ICar> where T : ICar, new()
{
    public ICar Create()
    {
        return new T();
    }
}   