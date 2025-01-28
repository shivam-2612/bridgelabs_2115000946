using System;
class Program
{
static int[] FindFactors(int number)
{
int count = 0;
for (int i = 1; i <= number; i++)
{
if (number % i == 0) count++;
}
int[] factors = new int[count];
int index = 0;
for (int i = 1; i <= number; i++)
{
if (number % i == 0) factors[index++] = i;
}
return factors;
}
static int SumFactors(int[] factors)
{
int sum = 0;
for (int i = 0; i < factors.Length; i++)
{
sum += factors[i];
}
return sum;
}
static long ProductFactors(int[] factors)
{
long product = 1;
for (int i = 0; i < factors.Length; i++)
{
product *= factors[i];
}
return product;
}
static double SumSquareFactors(int[] factors)
{
double sum = 0;
for (int i = 0; i < factors.Length; i++)
{
sum += Math.Pow(factors[i], 2);
}
return sum;
}
static void Main(string[] args)
{
Console.WriteLine("Enter a number:");
int number = int.Parse(Console.ReadLine());
int[] factors = FindFactors(number);
Console.WriteLine("Factors: " + string.Join(", ", factors));
Console.WriteLine("Sum: " + SumFactors(factors));
Console.WriteLine("Product: " + ProductFactors(factors));
Console.WriteLine("Sum of Squares: " + SumSquareFactors(factors));
}
}
