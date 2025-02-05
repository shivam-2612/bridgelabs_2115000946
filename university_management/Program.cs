class Student
{
    public int RollNumber { get; }
    protected string Name { get; }
    private double CGPA;

    public Student(int rollNumber, string name, double cgpa)
    {
        RollNumber = rollNumber;
        Name = name;
        CGPA = cgpa;
    }

    public double GetCGPA() => CGPA;
    public void SetCGPA(double cgpa) => CGPA = cgpa;
}

class PostgraduateStudent : Student
{
    public PostgraduateStudent(int rollNumber, string name, double cgpa) : base(rollNumber, name, cgpa) { }
}
