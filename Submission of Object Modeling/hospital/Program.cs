using System;
using System.Collections.Generic;

class Patient
{
    public string Name { get; set; }

    public Patient(string name)
    {
        Name = name;
    }
}

class Doctor
{
    public string Name { get; set; }

    public Doctor(string name)
    {
        Name = name;
    }

    public void Consult(Patient patient)
    {
        Console.WriteLine($"{Name} is consulting {patient.Name}");
    }
}

class Hospital
{
    public string Name { get; set; }

    public Hospital(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        Doctor doctor = new Doctor("Dr. Alice");
        Patient patient = new Patient("John Doe");
        doctor.Consult(patient);
    }
}
