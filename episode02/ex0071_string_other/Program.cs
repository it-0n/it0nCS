using System;

class Program
{
    enum CoffeeType
    {
        Espresso,
        Latte,
        Cappuccino
    }

    static void Main()
    {
        // Char: берём первый символ строки
        string singleChar = "H";
        char letter = Char.Parse(singleChar);
        WriteLine($"Буква: {letter}");

        // Boolean: включаем режим "Ночной страж"
        string nightMode = "true";
        bool isNightModeOn = Boolean.Parse(nightMode);
        WriteLine($"Ночной режим включён: {isNightModeOn}");

        // Enum: выбираем кофе
        string coffeeChoice = "Latte";
        CoffeeType coffee = (CoffeeType)Enum.Parse(typeof(CoffeeType), coffeeChoice);
        WriteLine($"Вы выбрали: {coffee}");
    }
}