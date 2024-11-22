namespace ex0014_global_using
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Операционная система: {OSDescription}");
            WriteLine("Имя класса: \u001b[38;5;214m{0}\u001b[0m", typeof(Program).Name);
            WriteLine("Имя пространства имён класса: \u001b[38;5;214m{0}\u001b[0m", typeof(Program).Namespace);
            WriteLine("Полное имя класса: \u001b[38;5;214m{0}\u001b[0m", typeof(Program).FullName);
            Write($"Текущий метод: ");
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"{MethodBase.GetCurrentMethod()?.Name}");
            ResetColor();
            var method = MethodBase.GetCurrentMethod();
            Write($"Полное имя текущего метода: ");
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"{method?.DeclaringType?.FullName}.{method?.Name}");
            ResetColor();
            Show.Environment();
        }
    }
}
