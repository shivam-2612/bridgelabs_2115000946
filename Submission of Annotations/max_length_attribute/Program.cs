using System;

[AttributeUsage(AttributeTargets.Property)]
class MaxLength : Attribute
{
    public int Length { get; }

    public MaxLength(int length)
    {
        Length = length;
    }
}

class User
{
    private string username;

    [MaxLength(10)]
    public string Username
    {
        get => username;
        set
        {
            if (value.Length > 10)
                throw new ArgumentException("Username exceeds maximum length");
            username = value;
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            User user = new User { Username = "ShortName" };
            Console.WriteLine("Username set successfully.");

            user.Username = "ThisUsernameIsTooLong";
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
