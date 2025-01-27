Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
if (number >= 0)
{
    int factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    Console.WriteLine($"Factorial of {number} is {factorial}");
}
else
{
    Console.WriteLine("Factorial is not defined for negative numbers");
}
