using System;

class Patient
{
    private static int totalPatients = 0;
    private static string HospitalName = "City Hospital";
    private readonly int PatientID;
    private string Name;
    private int Age;
    private string Ailment;

    public Patient(int patientID, string name, int age, string ailment)
    {
        this.PatientID = patientID;
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        totalPatients++;
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine($"Total Patients: {totalPatients}");
    }

    public void DisplayPatientDetails()
    {
        if (this is Patient)
        {
            Console.WriteLine($"Patient ID: {PatientID}, Name: {Name}, Age: {Age}, Ailment: {Ailment}, Hospital: {HospitalName}");
        }
    }
}
