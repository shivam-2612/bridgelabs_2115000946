using System;
using System.Collections.Generic;

abstract class JobRole { }
class SoftwareEngineer : JobRole { }
class DataScientist : JobRole { }

class Resume<T> where T : JobRole
{
    public string CandidateName { get; set; }
}

class ResumeProcessor
{
    public static void ProcessResumes<T>(List<T> resumes) where T : Resume<JobRole>
    {
        foreach (var resume in resumes)
            Console.WriteLine($"Processing resume of: {resume.CandidateName}");
    }
}

class Program
{
    static void Main()
    {
        List<Resume<SoftwareEngineer>> resumes = new List<Resume<SoftwareEngineer>>
        {
            new Resume<SoftwareEngineer> { CandidateName = "Alice" }
        };

        ResumeProcessor.ProcessResumes(resumes);
    }
}
