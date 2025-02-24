using System;
using System.Reflection;

class Person
{
    public string Name = "John";
    public int Age = 30;
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        Type type = typeof(Person);
        FieldInfo[] fields = type.GetFields();

        string json = "{ ";
        foreach (var field in fields)
        {
            json += $"\"{field.Name}\": \"{field.GetValue(person)}\", ";
        }
        json = json.TrimEnd(',', ' ') + " }";

        Console.WriteLine("JSON Representation: " + json);
    }
}
