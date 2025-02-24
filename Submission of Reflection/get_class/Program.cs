using System;
using System.Reflection;

class ReflectionDemo
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        Type type = Type.GetType(className);
        if (type != null)
        {
            Console.WriteLine($"\nClass: {type.FullName}");

            Console.WriteLine("\nMethods:");
            foreach (var method in type.GetMethods())
                Console.WriteLine(method.Name);

            Console.WriteLine("\nFields:");
            foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
                Console.WriteLine(field.Name);

            Console.WriteLine("\nConstructors:");
            foreach (var constructor in type.GetConstructors())
                Console.WriteLine(constructor.ToString());
        }
        else
        {
            Console.WriteLine("Class not found.");
        }
    }
}
