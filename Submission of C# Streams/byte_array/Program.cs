using System;
using System.IO;

class Program {
    static void Main() {
        string src = "img.png", dst = "img_copy.png";
        byte[] data = File.ReadAllBytes(src);
        File.WriteAllBytes(dst, data);
        Console.WriteLine("Image copied");
    }
}
