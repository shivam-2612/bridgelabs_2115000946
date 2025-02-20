using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Emp {
    public int id;
    public string name;
    public string dept;
    public double sal;
}

class Program {
    static void Main() {
        List<Emp> list = new List<Emp> {
            new Emp { id = 1, name = "A", dept = "HR", sal = 5000 },
            new Emp { id = 2, name = "B", dept = "IT", sal = 6000 }
        };
        File.WriteAllText("emp.json", JsonSerializer.Serialize(list));
        List<Emp> read = JsonSerializer.Deserialize<List<Emp>>(File.ReadAllText("emp.json"));
        foreach (var e in read) Console.WriteLine($"{e.id} {e.name} {e.dept} {e.sal}");
    }
}
