using System;

interface ismedical
{
    void adding(string record);
    void vieww();
}

abstract class Patient
{
    private int patient_Id;
    private string patient_name;
    private int patient_age;

    public int PatientId { get => patient_Id; }
    public string Name { get => patient_name; set => patient_name = value; }
    public int Age { get => patient_age; set => patient_age = value > 0 ? value : 1; }

    public Patient(int id, string patient_name, int patient_age)
    {
        this.patient_Id = id;
        this.Name = patient_name;
        this.Age = patient_age;
    }

    public abstract double bill_calculate();
    public void patient_deatails() => Console.WriteLine($"Patient: {Name}, Age: {Age}, Bill: {bill_calculate():C}");
}

class InPatient : Patient
{
    private int admissiondays;
    private double per_day;

    public InPatient(int id, string patient_name, int patient_age, int days, double charge) : base(id, patient_name, patient_age)
    {
        this.admissiondays = days;
        this.per_day = charge;
    }

    public override double bill_calculate() => admissiondays * per_day;
}

class Program
{
    static void Main()
    {
        Patient patient = new InPatient(101, "Shivam", 45, 5, 2000);
        patient.patient_deatails();
    }
}
