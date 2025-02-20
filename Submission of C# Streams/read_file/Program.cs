using System;
using System.IO;

class Program {
    static void Main() {
        using (StreamReader r = new StreamReader("large.txt")) {
            string line;
            while ((line = r.ReadLine()) != null) if (line.ToLower().Contains("error")) Console.WriteLine(line);
        }
    }
}
