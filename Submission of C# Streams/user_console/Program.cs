using System;
using System.IO;

class Program {
    static void Main() {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Age: ");
        string age = Console.ReadLine();
        Console.Write("Language: ");
        string lang = Console.ReadLine();
        using (StreamWriter w = new StreamWriter("user.txt")) w.WriteLine($"{name},{age},{lang}");
        Console.WriteLine("Saved");
    }
}
