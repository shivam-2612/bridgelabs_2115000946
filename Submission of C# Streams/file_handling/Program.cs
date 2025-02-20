using System;
using System.IO;

class Program {
    static void Main() {
        string src = "source.txt", dst = "dest.txt";
        if (!File.Exists(src)) {
            Console.WriteLine("Source file not found");
            return;
        }
        using (FileStream r = new FileStream(src, FileMode.Open, FileAccess.Read))
        using (FileStream w = new FileStream(dst, FileMode.Create, FileAccess.Write)) {
            r.CopyTo(w);
        }
        Console.WriteLine("File copied");
    }
}
