using System;
using System.IO;

class Program {
    static void Main() {
        using (BinaryWriter w = new BinaryWriter(File.Open("data.bin", FileMode.Create))) {
            w.Write(101);
            w.Write("John");
            w.Write(3.8);
        }
        using (BinaryReader r = new BinaryReader(File.Open("data.bin", FileMode.Open))) {
            Console.WriteLine($"{r.ReadInt32()} {r.ReadString()} {r.ReadDouble()}");
        }
    }
}
