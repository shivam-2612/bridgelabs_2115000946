﻿using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b) => a * b;
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Type type = typeof(Calculator);
        MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        object result = method.Invoke(calc, new object[] { 5, 4 });
        Console.WriteLine("Result: " + result);
    }
}
