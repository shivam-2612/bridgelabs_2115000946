Console.Write("Enter a natural number: ");
int n = int.Parse(Console.ReadLine());
if (n > 0)
{
    int sum = 0;
    int i = 1;
    while (i <= n)
    {
        sum += i;
        i++;
    }
    int formulaSum = n * (n + 1) / 2;
    Console.WriteLine($"Sum using loop: {sum}, Sum using formula: {formulaSum}");
}
else
{
    Console.WriteLine("Not a natural number");
}
