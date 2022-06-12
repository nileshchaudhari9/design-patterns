namespace AbstractFactoryDemo; 

internal interface IAbstractProductB {
    string UsefulFunctionB();

     string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}