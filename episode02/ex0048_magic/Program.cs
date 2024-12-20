public class ValueTypeExample
{
    public static void Main()
    {
        // Тип значения
        int number = 42;
        double pi = 3.14;
        bool isHappy = true;

        // Вызов метода GetType()
        WriteLine($"number: {number}, Type: {number.GetType()}"); // System.Int32
        WriteLine($"pi: {pi}, Type: {pi.GetType()}"); // System.Double
        WriteLine($"isHappy: {isHappy}, Type: {isHappy.GetType()}"); // System.Boolean
    }
}