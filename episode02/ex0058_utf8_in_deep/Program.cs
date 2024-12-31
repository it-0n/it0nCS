using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Литерал UTF8
        var utf8Literal = "HTTP/1.1\r\n"u8;

        // Передача в метод
        WriteBytes(utf8Literal);
        WriteLine($"\n {Encoding.UTF8.GetString(utf8Literal)}");

        // Объединение
        var combined = "Content-Length: "u8 + "1108"u8;
        WriteBytes(combined);
        WriteLine($"\n{Encoding.UTF8.GetString(combined)}\n");

        // Конвертация в массив байтов
        byte[] bytes = combined.ToArray();
        WriteBytes(bytes);
        WriteLine($"\n {Encoding.UTF8.GetString(bytes)}");
    }

    // Метод для записи байтов
    static void WriteBytes(ReadOnlySpan<byte> data)
    {
        foreach (byte b in data)
        {
            Write($"{b:X2} ");
        }
    }
}
