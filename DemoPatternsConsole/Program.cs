// See https://aka.ms/new-console-template for more information


using AbsFactoryClient =  AbstractFactoryDemo.Client;
using PlainFactoryClient = PlainFactory.Client;
using _Singleton =  Singleton.Singleton;
using CommandClient = CommandDemo.Client;
using FacadeClient = FacadeDemo.Client;
using GenericFactoryClient = GenericFactory.Client;
using DIClient = DependencyInjectionDemo.Client;

new AbsFactoryClient().Main();

Console.WriteLine("================================");
Console.WriteLine();

new PlainFactoryClient().Main();

Console.WriteLine("================================");
Console.WriteLine();

var task = Task.Run(() => _Singleton.GetInstance("FOO"));
var task1 = Task.Run(() => _Singleton.GetInstance("BAR"));

var tasks =  Task.WhenAll(new [] { task, task1});
var result = tasks.Result;
foreach (var x in result)
    Console.WriteLine(x.Value);

Console.WriteLine($"Value from Singleton should be {_Singleton.GetInstance("BLABAL").Value}");

Console.WriteLine("================================");
Console.WriteLine();

new CommandClient().Main();

Console.WriteLine("================================");
Console.WriteLine();

FacadeClient.ClientCode();

Console.WriteLine("================================");
Console.WriteLine();

new GenericFactoryClient().Main();

Console.WriteLine("================================");
Console.WriteLine();

new DIClient().Main().GetAwaiter().GetResult();