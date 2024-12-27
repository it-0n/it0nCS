public class Program
{
    public static void Main()
    {
        var type = "STRING".GetType();
        do
        {
            WriteLine(type.FullName);
            type = type.BaseType;
        }
        while (type != null);
    }
}