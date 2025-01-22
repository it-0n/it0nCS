using System;
using System.Threading;

class Program
{
    static void Main()
    {
        WriteLine("Нажимайте клавиши (Esc - выход).");

        while (true)
        {
            if (KeyAvailable) // Проверяем, есть ли нажатая клавиша
            {
                ConsoleKeyInfo key = ReadKey(true); // Читаем клавишу без вывода в консоль
                WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifiers: {key.Modifiers}");

                if (key.Key == ConsoleKey.Escape)
                {
                    WriteLine("Выход из программы...");
                    break;
                }
            }

            // Тут может выполняться другой код, например игровой цикл
            Thread.Sleep(100); // Задержка, чтобы процессор не перегружался
        }
    }
}