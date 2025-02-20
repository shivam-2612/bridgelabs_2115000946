using System;
using System.IO;

class Program {
    static void Main() {
        using (StreamReader r = new StreamReader("input.txt"))
        using (StreamWriter w = new StreamWriter("output.txt")) {
            string line;
            while ((line = r.ReadLine()) != null) w.WriteLine(line.ToLower());
        }
        Console.WriteLine("Conversion Done");
    }
}
