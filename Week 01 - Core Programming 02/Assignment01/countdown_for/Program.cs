Console.Write("Enter countdown start value: ");
int counter = int.Parse(Console.ReadLine());
for (int i = counter; i >= 1; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("Liftoff!");
