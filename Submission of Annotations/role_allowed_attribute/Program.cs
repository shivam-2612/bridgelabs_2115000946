using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowed : Attribute
{
    public string Role { get; }

    public RoleAllowed(string role)
    {
        Role = role;
    }
}

class AccessControl
{
    [RoleAllowed("ADMIN")]
    public void AdminTask()
    {
        Console.WriteLine("Admin task executed.");
    }
}

class Program
{
    static void Main()
    {
        string currentUserRole = "USER";
        var methods = typeof(AccessControl).GetMethods();
        var instance = new AccessControl();

        foreach (var method in methods)
        {
            var attr = method.GetCustomAttribute<RoleAllowed>();
            if (attr != null)
            {
                if (attr.Role == currentUserRole)
                    method.Invoke(instance, null);
                else
                    Console.WriteLine("Access Denied!");
            }
        }
    }
}
