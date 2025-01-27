using System;

class Program
{
    public static void Main(String[] args)
    {
        int pens = 14;
        int students = 3;

        int Pen_Per_Student = (pens/students);
        int remain = (pens%students);

        Console.WriteLine("The Pen Per Student is " + Pen_Per_Student + " and the remaining pen not distributed is "+remain);
    }
}
