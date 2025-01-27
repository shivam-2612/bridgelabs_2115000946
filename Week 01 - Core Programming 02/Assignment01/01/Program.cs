Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Is the number {number} divisible by 5? {number % 5 == 0}");
