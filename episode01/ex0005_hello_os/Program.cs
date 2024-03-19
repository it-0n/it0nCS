namespace ex0005_hello_os;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Hello, {System.Runtime.InteropServices.RuntimeInformation.OSDescription}");
    }
}
