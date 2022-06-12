namespace AbstractFactoryDemo; 

internal class Factory: IAbstractFactory 
{
    public IAbstractProductA CreateProductA() => new ProductA();
    
    public IAbstractProductB CreateProductB() => new ProductB();
}