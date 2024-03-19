namespace ex0006VSCodeProject02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Операционная система: {System.Runtime.InteropServices.RuntimeInformation.OSDescription}");
        Console.WriteLine($"Текущая директория: {Environment.CurrentDirectory}");
        Console.WriteLine("Имя класса: {0}", typeof(Program).Name);
        Console.WriteLine("Имя пространства имён класса: {0}", typeof(Program).Namespace);
        Console.WriteLine("Полное имя: {0}", typeof(Program).FullName);
    }
}
