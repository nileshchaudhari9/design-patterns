namespace CommandDemo;

internal class ComplexCommand:  ICommand
{
    private Receiver _receiver;
    // Context data, required for launching the receiver's methods.
    private string _a;
    private string _b;

    public ComplexCommand(Receiver receiver, string a, string b)
    {
        this._receiver = receiver;
        this._a = a;
        this._b = b;
    }
    public void Execute() {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);
    }
}