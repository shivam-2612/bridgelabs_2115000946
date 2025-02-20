using System;
using System.Diagnostics;
using System.IO;

class Program {
    static void CopyFile(string src, string dst, bool useBuffer) {
        using (FileStream r = new FileStream(src, FileMode.Open, FileAccess.Read))
        using (FileStream w = new FileStream(dst, FileMode.Create, FileAccess.Write)) {
            if (useBuffer) using (BufferedStream br = new BufferedStream(r, 4096))
            using (BufferedStream bw = new BufferedStream(w, 4096)) br.CopyTo(bw);
            else r.CopyTo(w);
        }
    }

    static void Main() {
        string src = "largefile.dat", dst1 = "copy1.dat", dst2 = "copy2.dat";
        Stopwatch sw = Stopwatch.StartNew();
        CopyFile(src, dst1, false);
        sw.Stop();
        Console.WriteLine($"Unbuffered: {sw.ElapsedMilliseconds} ms");
        sw.Restart();
        CopyFile(src, dst2, true);
        sw.Stop();
        Console.WriteLine($"Buffered: {sw.ElapsedMilliseconds} ms");
    }
}
