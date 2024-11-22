namespace ex0014_global_using;

class Show
{
    public static void Environment()
    {
        ForegroundColor = ConsoleColor.Cyan;
        WriteLine($"Имя компьютера {Env.MachineName}");
        WriteLine($"Текущая директория: {Env.CurrentDirectory}");
        ResetColor();
    }
}