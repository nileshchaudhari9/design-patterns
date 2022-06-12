namespace AbstractFactoryDemo; 

internal class ProductB: IAbstractProductB {
   public string UsefulFunctionB() => "This is method called from Product B";

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator) => 
    $"From Product B, called Product A method - {collaborator.UsefulFunctionA}";
}