class Program
{
    static void Main()
    {
        // Маленький ящик для чисел (byte)
        byte smallBox = 100; 
        Console.WriteLine($"Маленький ящик (byte): {smallBox}");

        // Большой ящик для чисел (int)
        int bigBox = 500; 
        Console.WriteLine($"Большой ящик (int): {bigBox}");

        // Преобразование int в byte с потерей данных
        smallBox = (byte)bigBox; 
        Console.WriteLine($"Маленький ящик после преобразования (byte): {smallBox}");

        // Ящик для текста (string)
        string textBox = "Привет, мир!"; 
        Console.WriteLine($"Ящик для текста (string): {textBox}");

        // Автоматический выбор ящика с var
        var autoBox = 42; 
        Console.WriteLine($"Автоматический ящик (var, int): {autoBox}");

        // Изменение значения autoBox (тип остаётся int)
        autoBox = 1000; 
        Console.WriteLine($"Автоматический ящик с новым значением: {autoBox}");

        // Попытка присвоить текст вызовет ошибку
        // autoBox = "Ошибка"; // Нельзя, так как autoBox — это int
    }
}