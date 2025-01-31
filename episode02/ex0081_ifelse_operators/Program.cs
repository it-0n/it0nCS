class Program
{
    static void Main()
    {
        if (!int.TryParse(ReadInput("Введите ваш возраст: "), out int age) || age < 0)
        {
            WriteLine("Ошибка: Введите корректное число!");
            return;
        }

        // Простое if-else
        if (age >= 18)
        {
            WriteLine("Вы совершеннолетний.");
        }
        else
        {
            WriteLine("Вы несовершеннолетний.");
        }

        // if-else if-else
        if (age < 12)
        {
            WriteLine("Вы ребенок.");
        }
        else if (age < 18)
        {
            WriteLine("Вы подросток.");
        }
        else
        {
            WriteLine("Вы взрослый.");
        }

        // Тернарный оператор
        string status = (age >= 18) ? "совершеннолетний" : "несовершеннолетний";
        WriteLine($"Ваш статус: {status}");

        // Логические операторы &&, ||
        if (age >= 18 && age < 65)
        {
            WriteLine("Вы трудоспособного возраста.");
        }
        if (age < 18 || age > 60)
        {
            WriteLine("Вы получаете социальные льготы.");
        }

        // Вложенные if
        if (age >= 18)
        {
            string? gender = ReadInput("Введите ваш пол (м/ж): ")?.ToLower();
            if (gender == "м")
            {
                WriteLine("Вы мужчина.");
            }
            else if (gender == "ж")
            {
                WriteLine("Вы женщина.");
            }
            else
            {
                WriteLine("Ошибка: Некорректный ввод.");
            }
        }

        // Граничные условия
        if (age == 18)
        {
            WriteLine("Поздравляем! Вам только исполнилось 18.");
        }
        if (age == 60)
        {
            WriteLine("Поздравляем! Вы достигли пенсионного возраста.");
        }
    }
}