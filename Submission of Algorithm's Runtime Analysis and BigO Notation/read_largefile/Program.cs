using System;
using System.IO;

class FileReadingComparison
{
    public static void ReadWithStreamReader(string filePath)
    {
        using StreamReader sr = new StreamReader(filePath);
        while (sr.ReadLine() != null) { }
    }

    public static void ReadWithFileStream(string filePath)
    {
        using FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        byte[] buffer = new byte[1024];
        while (fs.Read(buffer, 0, buffer.Length) > 0) { }
    }
}
