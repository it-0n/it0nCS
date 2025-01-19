using System;

class Program
{
    static void Main()
    {
        WriteLine("Нажимайте клавиши. Для выхода нажмите Esc.");
        
        while (true)
        {
            ConsoleKeyInfo key = ReadKey(true); // true означает, что клавиша не будет отображаться в консоли
            WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", key.Key, key.KeyChar, key.Modifiers);
            
            if (key.Key == ConsoleKey.Escape)
            {
                WriteLine("Вы нажали Esc. Завершаем программу...");
                break;
            }
        }
    }
}