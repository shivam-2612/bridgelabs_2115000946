using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        using (FileStream fs = new FileStream("binaryfile.bin", FileMode.Open))
        using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
        {
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
