using System;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void MakeSound() => Console.WriteLine("Animal makes a sound");
}

class Dog : Animal
{
    public override void MakeSound() => Console.WriteLine("Dog barks");
}

class Cat : Animal
{
    public override void MakeSound() => Console.WriteLine("Cat meows");
}

class Bird : Animal
{
    public override void MakeSound() => Console.WriteLine("Bird chirps");
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog();
        Animal cat = new Cat();
        Animal bird = new Bird();
        
        dog.MakeSound();
        cat.MakeSound();
        bird.MakeSound();
    }
}
