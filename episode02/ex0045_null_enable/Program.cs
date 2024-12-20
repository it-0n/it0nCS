public class Program
{
    public static void Main()
    {
        string nonNullable = "Hello"; // Не может быть null
        string? nullable = null; // Может быть null

        WriteLine($"nonNullable.Length = {nonNullable.Length}"); // Безопасно

        //WriteLine(nullable.Length); // Не безопасно

        if (nullable != null) // проверка что имеет значение, то есть не null
        {
            WriteLine(nullable.Length); // Безопасно
        }
    }
}