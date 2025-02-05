class Employee
{
    public int EmployeeID { get; }
    protected string Department { get; }
    private double Salary;

    public Employee(int employeeID, string department, double salary)
    {
        EmployeeID = employeeID;
        Department = department;
        Salary = salary;
    }

    public void SetSalary(double newSalary) => Salary = newSalary;
}

class Manager : Employee
{
    public Manager(int employeeID, string department, double salary) : base(employeeID, department, salary) { }
}
