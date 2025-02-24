using System;
using System.Collections;

class Program
{
    static void Main()
    {
        #pragma warning disable
        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add("string");
        list.Add(3.14);
        #pragma warning restore

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
