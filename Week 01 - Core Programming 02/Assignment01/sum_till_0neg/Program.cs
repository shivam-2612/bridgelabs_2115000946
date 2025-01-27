double total = 0.0;
while (true)
{
    Console.Write("Enter a number (0 or negative to stop): ");
    double input = double.Parse(Console.ReadLine());
    if (input <= 0)
        break;
    total += input;
}
Console.WriteLine($"The total sum is {total}");
