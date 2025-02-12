using System;

class Student
{
    public int RollNo;
    public string Name;
    public int Age;
    public string Grade;
    public Student Next;
}

class StudentManager
{
    private Student head;

    public void AddStudent(int roll, string name, int age, string grade, int position = -1)
    {
        Student newNode = new Student { RollNo = roll, Name = name, Age = age, Grade = grade, Next = null };
        if (head == null || position == 0)
        {
            newNode.Next = head;
            head = newNode;
            return;
        }
        Student temp = head;
        int index = 1;
        while (temp.Next != null && (position == -1 || index < position))
        {
            temp = temp.Next;
            index++;
        }
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    public void RemoveStudent(int roll)
    {
        if (head == null) return;
        if (head.RollNo == roll)
        {
            head = head.Next;
            return;
        }
        Student temp = head;
        while (temp.Next != null && temp.Next.RollNo != roll)
        {
            temp = temp.Next;
        }
        if (temp.Next != null) temp.Next = temp.Next.Next;
    }

    public Student FindStudent(int roll)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNo == roll) return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void DisplayStudents()
    {
        Student temp = head;
        while (temp != null)
        {
            Console.WriteLine($"RollNo: {temp.RollNo}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
            temp = temp.Next;
        }
    }

    public void UpdateGrade(int roll, string newGrade)
    {
        Student student = FindStudent(roll);
        if (student != null) student.Grade = newGrade;
    }
}
