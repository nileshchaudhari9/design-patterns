namespace GenericFactory;

internal interface IFactory<T>
{
    T Create();
} 