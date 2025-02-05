class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
    }
}
