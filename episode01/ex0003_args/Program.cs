namespace ex0003_args;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Было передано аргументов {args.Length}");
        if(args.Length > 0 )
            Console.WriteLine($"Первый переданный аргумент: {args[0]}");
    }
}
