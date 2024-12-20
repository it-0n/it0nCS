public class Program
{
    public static void Main()
    {
        string? nullable = null; // Допустимо, но опасно
        string nonNullable = null; // Допустимо, но опасно
        
        WriteLine($"nullable.Length = {nullable.Length}"); // Возможен NullReferenceException
        WriteLine($"nonNullable.Length = {nonNullable.Length}"); // Возможен NullReferenceException
    }
}