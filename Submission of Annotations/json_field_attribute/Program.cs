using System;
using System.Reflection;
using System.Text;

[AttributeUsage(AttributeTargets.Property)]
class JsonField : Attribute
{
    public string Name { get; }

    public JsonField(string name)
    {
        Name = name;
    }
}

class User
{
    [JsonField("user_name")]
    public string Username { get; set; }

    [JsonField("user_email")]
    public string Email { get; set; }
}

class Serializer
{
    public static string ToJson(object obj)
    {
        StringBuilder json = new StringBuilder("{");
        var properties = obj.GetType().GetProperties();

        foreach (var prop in properties)
        {
            var attr = prop.GetCustomAttribute<JsonField>();
            if (attr != null)
            {
                string value = prop.GetValue(obj)?.ToString();
                json.AppendFormat($"\"{attr.Name}\": \"{value}\", ");
            }
        }

        if (json.Length > 1)
            json.Remove(json.Length - 2, 2);

        json.Append("}");
        return json.ToString();
    }
}

class Program
{
    static void Main()
    {
        User user = new User { Username = "johndoe", Email = "john@example.com" };
        string json = Serializer.ToJson(user);
        Console.WriteLine(json);
    }
}
