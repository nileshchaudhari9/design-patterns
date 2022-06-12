namespace CommandDemo;

internal class Invoker 
{

    private ICommand? onStart = null;
    private ICommand? onFinish = null;

    public void SetOnStart(ICommand command) {
        onStart = command;
    }

    public void SetOnFinish(ICommand command)
    {
        this.onFinish = command;
    }

    public void DoSomethingImportant()
    {
        Console.WriteLine("Invoker: Does anybody want something done before I begin?");
        if (this.onStart is ICommand)
        {
            this.onStart.Execute();
        }
        
        Console.WriteLine("Invoker: ...doing something really important...");
        
        Console.WriteLine("Invoker: Does anybody want something done after I finish?");
        if (this.onFinish is ICommand)
        {
            this.onFinish.Execute();
        }
    }
}