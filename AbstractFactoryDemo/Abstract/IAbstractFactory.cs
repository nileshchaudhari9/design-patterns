namespace AbstractFactoryDemo;

internal interface IAbstractFactory 
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}