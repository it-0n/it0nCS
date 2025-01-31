using System;

enum OrderStatus
{
    New,
    Processing,
    Shipped,
    Delivered,
    Canceled
}

class Program
{
    static void Main()
    {
        WriteLine("Выберите действие: ");
        WriteLine("1 - Добавить товар в корзину");
        WriteLine("2 - Оплатить заказ");
        WriteLine("3 - Отменить заказ");
        WriteLine("4 - Проверить статус заказа");

        if (!int.TryParse(ReadInput("Введите номер: "), out int action))
        {
            WriteLine("Ошибка: Введите число от 1 до 4!");
            return;
        }

        switch (action)
        {
            case 1:
                WriteLine("Товар добавлен в корзину.");
                break;
            case 2:
                WriteLine("Заказ оплачен.");
                break;
            case 3:
                WriteLine("Заказ отменён.");
                break;
            case 4:
                CheckOrderStatus();
                break;
            default:
                WriteLine("Ошибка: Некорректный ввод.");
                break;
        }
    }

    static void CheckOrderStatus()
    {
        if (!Enum.TryParse(ReadInput("Введите статус заказа (New, Processing, Shipped, Delivered, Canceled): "), true, out OrderStatus status))
        {
            WriteLine("Ошибка: Некорректный статус.");
            return;
        }

        // switch с enum
        switch (status)
        {
            case OrderStatus.New:
                WriteLine("Ваш заказ новый и ещё не обработан.");
                break;
            case OrderStatus.Processing:
                WriteLine("Ваш заказ в обработке.");
                break;
            case OrderStatus.Shipped:
                WriteLine("Ваш заказ отправлен.");
                break;
            case OrderStatus.Delivered:
                WriteLine("Ваш заказ доставлен.");
                break;
            case OrderStatus.Canceled:
                WriteLine("Ваш заказ отменён.");
                break;
            default:
                WriteLine("Ошибка: Неизвестный статус.");
                break;
        }

        // goto case
        switch (status)
        {
            case OrderStatus.New:
                WriteLine("Мы скоро начнем обработку заказа.");
                goto case OrderStatus.Processing;
            case OrderStatus.Processing:
                WriteLine("Ожидайте отправку.");
                break;
            case OrderStatus.Shipped:
            case OrderStatus.Delivered:
                WriteLine("Заказ уже в пути или доставлен.");
                break;
            case OrderStatus.Canceled:
                WriteLine("К сожалению, заказ отменён.");
                goto default;
            default:
                WriteLine("Нет информации о заказе.");
                break;
        }

        // switch-выражение
        string message = status switch
        {
            OrderStatus.New => "Заказ ожидает обработки.",
            OrderStatus.Processing => "Заказ в обработке.",
            OrderStatus.Shipped => "Заказ отправлен.",
            OrderStatus.Delivered => "Заказ доставлен.",
            OrderStatus.Canceled => "Заказ отменён.",
            _ => "Неизвестный статус."
        };
        WriteLine($"[INFO]: {message}");
    }
}