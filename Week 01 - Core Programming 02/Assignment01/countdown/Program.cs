Console.Write("Enter countdown start value: ");
int counter = int.Parse(Console.ReadLine());
while (counter >= 1)
{
    Console.WriteLine(counter);
    counter--;
}
Console.WriteLine("Liftoff!");
