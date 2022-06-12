namespace PlainFactory;

internal class ConcreteCreator: Creator {

    public override IProduct FactoryMethod() => new Product();
}