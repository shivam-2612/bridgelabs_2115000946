﻿using System;
using System.Reflection;

class Person
{
    private int age = 25;
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        Type type = typeof(Person);
        FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        field.SetValue(person, 30);
        Console.WriteLine("Modified Age: " + field.GetValue(person));
    }
}
