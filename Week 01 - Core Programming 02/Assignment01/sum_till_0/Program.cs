double total = 0.0;
double input;
do
{
    Console.Write("Enter a number (0 to stop): ");
    input = double.Parse(Console.ReadLine());
    total += input;
} while (input != 0);
Console.WriteLine($"The total sum is {total}");
