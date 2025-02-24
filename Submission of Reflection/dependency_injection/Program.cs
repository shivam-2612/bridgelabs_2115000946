using System;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Property)]
class InjectAttribute : Attribute { }

class Service { public void Execute() => Console.WriteLine("Service Executed"); }

class Consumer
{
    [Inject]
    public Service Service { get; set; }
}

class DIContainer
{
    public void InjectDependencies(object obj)
    {
        var properties = obj.GetType().GetProperties()
            .Where(p => Attribute.IsDefined(p, typeof(InjectAttribute)));

        foreach (var property in properties)
        {
            var instance = Activator.CreateInstance(property.PropertyType);
            property.SetValue(obj, instance);
        }
    }
}

class Program
{
    static void Main()
    {
        var container = new DIContainer();
        var consumer = new Consumer();
        container.InjectDependencies(consumer);
        consumer.Service.Execute();
    }
}
