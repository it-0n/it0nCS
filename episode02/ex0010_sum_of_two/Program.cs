using System.Globalization;

namespace ex0010_sum_of_two // более явно определили пространство имен
{ // начало блока namespace ex0010_sum_of_two

    class Program
    { // начало блока класса Program
        static void Main(string[] args)
        { // начало блока статического метода Main
            Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16"); // устанавливаем кодировку для символов
            Console.Write("Введите первое число: ");
            var input1 = Console.ReadLine(); // здесь получаем строку в переменную input1

            Console.Write("Введите второе число: ");
            var input2 = Console.ReadLine(); // здесь получаем строку в переменную input2

            /* 
            Проверяем возможность преобразолвания введенных строк в числа с учетом дробной части.
            И если преобразуется без ошибок, то производится преобразование введенных строк в числа
            которые заносятся в переменные number1 и nuber2. После чего выводится сумма этих переменных.
            */
            if (double.TryParse(input1, NumberStyles.Any, CultureInfo.InvariantCulture, out double number1) &&
                double.TryParse(input2, NumberStyles.Any, CultureInfo.InvariantCulture, out double number2))
            { // начало блока положительной проверки оператора if
                //double sum = number1 + number2; // закомментировали эту строку, так как в принципе она не нужна для правильной работы программы
                Console.WriteLine($"Сумма чисел: {number1 + number2}"); // выводим результат
            } // конец блока положительной проверки оператора if
            else
            { // начало блока отрицательной проверки оператора if   
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите числа."); // если введенные данные не удалось преобразовать в числа, то выводим сообщение об ошибке
            } // конец блока отрицательной проверки оператора if 

        } // конец блока статического метода Main
    } // конец блока класса Program
} // конец блока namespace ex0010_sum_of_two
