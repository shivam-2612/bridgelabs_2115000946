using System;
using System.Reflection;

public interface IGreeting
{
    void SayHello();
}

public class Greeting : IGreeting
{
    public void SayHello() => Console.WriteLine("Hello!");
}

public class LoggingProxy : DispatchProxy
{
    private IGreeting _decorated;

    protected override object Invoke(MethodInfo method, object[] args)
    {
        Console.WriteLine($"Method {method.Name} is being called");
        return method.Invoke(_decorated, args);
    }

    public static IGreeting Create(IGreeting decorated)
    {
        var proxy = Create<IGreeting, LoggingProxy>();
        ((LoggingProxy)(object)proxy)._decorated = decorated;
        return proxy;
    }
}

class Program
{
    static void Main()
    {
        IGreeting greeting = new Greeting();
        IGreeting proxy = LoggingProxy.Create(greeting);
        proxy.SayHello();
    }
}
