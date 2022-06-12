namespace CommandDemo;

internal class SimpleCommand:  ICommand
{
    private string _payload = string.Empty;
    public SimpleCommand(string payload)
    {
        _payload = payload;
    }
    public void Execute() => 
    Console.WriteLine($"This is execution of SimpleCommand with payload {_payload}");
}