using System;

interface Worker
{
    void PerformDuties();
}

class Person
{
    public string Name { get; set; }
    public int Id { get; set; }
}

class Chef : Person, Worker
{
    public void PerformDuties() => Console.WriteLine($"{Name} is cooking food.");
}

class Waiter : Person, Worker
{
    public void PerformDuties() => Console.WriteLine($"{Name} is serving food.");
}

class Program
{
    static void Main()
    {
        Worker chef = new Chef { Name = "John", Id = 1 };
        Worker waiter = new Waiter { Name = "Emma", Id = 2 };

        chef.PerformDuties();
        waiter.PerformDuties();
    }
}
