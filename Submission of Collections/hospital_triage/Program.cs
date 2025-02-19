using System;
using System.Collections.Generic;

class Patient
{
    public string Name { get; set; }
    public int Severity { get; set; }

    public Patient(string name, int severity)
    {
        Name = name;
        Severity = severity;
    }
}

class SeverityComparer : IComparer<Patient>
{
    public int Compare(Patient x, Patient y) => y.Severity.CompareTo(x.Severity);
}

class Program
{
    static void Main()
    {
        PriorityQueue<Patient, Patient> triageQueue = new PriorityQueue<Patient, Patient>(new SeverityComparer());

        triageQueue.Enqueue(new Patient("John", 3), new Patient("John", 3));
        triageQueue.Enqueue(new Patient("Alice", 5), new Patient("Alice", 5));
        triageQueue.Enqueue(new Patient("Bob", 2), new Patient("Bob", 2));

        while (triageQueue.Count > 0)
        {
            Patient nextPatient = triageQueue.Dequeue();
            Console.WriteLine(nextPatient.Name);
        }
    }
}
