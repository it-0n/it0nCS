using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Пример 1: Простая строка UTF-8 как массив байт
        byte[] utf8Bytes = "Hello, UTF-8!"u8.ToArray(); // Преобразуем ReadOnlySpan<byte> в byte[]
        WriteLine($"Length of UTF-8 array: {utf8Bytes.Length}");

        // Пример 2: Работа с Unicode, тоже преобразование в byte[]
        byte[] emoji = "😊"u8.ToArray();
        WriteLine($"Length of emoji in UTF-8: {emoji.Length}");

        // Пример 3: Взаимодействие с API
        var utf8String = "Content-Type: application/json"u8;
        SendToApi(utf8String);

        // Пример 4: Конкатенация UTF-8 строк только через свои реализации
        var part1 = "Hello, "u8.ToArray();
        var part2 = "world!"u8.ToArray();
        var fullMessage = CombineByteArrays(part1, part2); // используем свой метод
        WriteLine(Encoding.UTF8.GetString(fullMessage));

        // Пример 5: Интерполяция строк не работает с использованием суффикса u8
        var name = "Alice";
        // var greeting = $"Hello, {name}!"u8; // так работать не будет
        // проэтому получаем масиив байт другим спосбобом
        var greeting = Encoding.UTF8.GetBytes($"Hello, {name}!");
        WriteLine(Encoding.UTF8.GetString(greeting));

        // Пример 6: Необработанный строковый литерал
        var json = """
        {
            "name": "Alice",
            "age": 30
        }
        """u8;
        WriteLine(Encoding.UTF8.GetString(json));
    }

    // Вспомогательный метод для объединения массивов байтов
    static byte[] CombineByteArrays(byte[] first, byte[] second)
    {
        var combined = new byte[first.Length + second.Length];
        Buffer.BlockCopy(first, 0, combined, 0, first.Length);
        Buffer.BlockCopy(second, 0, combined, first.Length, second.Length);
        return combined;
    }

    // Метод для отправки байтового массива в API
    static void SendToApi(ReadOnlySpan<byte> data)
    {
        WriteLine($"Sending to API: {Encoding.UTF8.GetString(data)}");
    }
}
