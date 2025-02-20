using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class Program {
    static void Write(PipeStream p) {
        using (StreamWriter w = new StreamWriter(p)) {
            w.AutoFlush = true;
            w.WriteLine("Hello from Writer");
        }
    }

    static void Read(PipeStream p) {
        using (StreamReader r = new StreamReader(p)) Console.WriteLine(r.ReadLine());
    }

    static void Main() {
        using (AnonymousPipeServerStream s = new AnonymousPipeServerStream(PipeDirection.Out))
        using (AnonymousPipeClientStream c = new AnonymousPipeClientStream(PipeDirection.In, s.ClientSafePipeHandle)) {
            Thread t1 = new Thread(() => Write(s)), t2 = new Thread(() => Read(c));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }
    }
}
