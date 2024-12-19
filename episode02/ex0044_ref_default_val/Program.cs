class Example
{
    public string Name;  // Ссылочный тип
    public object Data;  // Ссылочный тип
}

class Program
{
    static void Main()
    {
        Example example = new Example();
        WriteLine($"Name: {example.Name ?? "null"}"); // null
        WriteLine($"Data: {example.Data ?? "null"}"); // null
    }
}