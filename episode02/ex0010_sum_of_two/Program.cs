using System.Globalization;

namespace ex0010_sum_of_two // более явно определили пространство имен
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16"); // устанавливаем кодировку для символов
            Console.Write("Введите первое число: ");
            var input1 = Console.ReadLine();

            Console.Write("Введите второе число: ");
            var input2 = Console.ReadLine();

            /* 
            Проверяем возможность преобразолвания введенных строк в числа с учетом дробной части.
            И если преобразуется без ошибок, то производится преобразование введенных строк в числа,
            затем вычисляется сумма этих чисел и выводится результат.
            */
            if (double.TryParse(input1, NumberStyles.Any, CultureInfo.InvariantCulture, out double number1) &&
                double.TryParse(input2, NumberStyles.Any, CultureInfo.InvariantCulture, out double number2))
            {
                double sum = number1 + number2; // складываем числа
                Console.WriteLine($"Сумма чисел: {sum}"); // выводим результат
            }
            else
            {   // если введенные данные не удалось преобразовать в числа, то выводим сообщение об ошибке
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите числа.");
            }

        }
    }
}
