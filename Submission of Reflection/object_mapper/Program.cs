using System;
using System.Collections.Generic;
using System.Reflection;

class Person
{
    public string Name;
    public int Age;
}

class ObjectMapper
{
    public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
    {
        T obj = new T();
        Type type = typeof(T);

        foreach (var prop in properties)
        {
            FieldInfo field = type.GetField(prop.Key);
            if (field != null)
                field.SetValue(obj, prop.Value);
        }

        return obj;
    }
}

class Program
{
    static void Main()
    {
        var properties = new Dictionary<string, object> { { "Name", "Alice" }, { "Age", 28 } };
        Person person = ObjectMapper.ToObject<Person>(properties);

        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}
