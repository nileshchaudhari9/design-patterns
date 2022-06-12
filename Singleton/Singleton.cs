namespace Singleton;
public sealed class Singleton
{
    private Singleton() { }

    private static Singleton? _instance = null;
    private static readonly object _lock = new Object();

    public static Singleton GetInstance(string value) 
    {
        if (_instance == null) {
             lock(_lock) 
             {
                if (_instance == null) 
                {
                    _instance = new Singleton();
                    _instance.Value = value;
                }
             }
        }
        return _instance; 
    }

    // Finally, any singleton should define some business logic, which can
    // be executed on its instance.
    public void someBusinessLogic()
    {
        // ...
    }

    public string Value { get; set; } = string.Empty;
}
