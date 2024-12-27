class Program
{
    static string[] foodSymbols = { "♥", "🍎", "🍌", "🍒", "🍇", "🍉", "🍑", "🍓", "🍍", "🥭" };
    static Random random = new Random();

    static int consoleWidth;
    static int consoleHeight;

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        if (!SetConsoleDimensions())
        {
            Console.Clear();
            Console.WriteLine("Увеличьте размер окна консоли до минимальных размеров 20x10.");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
            return;
        }

        Console.Clear();
        Console.CursorVisible = false;

        int totalPoints = 0; // Общие очки игрока
        int speed = 200; // Начальная скорость
        bool isRunning = true;
        bool isPaused = false;
        var snake = new List<(int x, int y)> { (consoleWidth / 2, consoleHeight / 2) };
        var food = new List<(string symbol, int x, int y, int foodPoints, int lifetime)>();
        var direction = (dx: 0, dy: -1);

        DrawBorder();

        while (isRunning)
        {
            if (!isPaused)
            {
                // Удаляем истёкшую еду
                food.RemoveAll(f => f.lifetime <= 0);

                // Добавляем еду, если её меньше трёх
                while (food.Count < 3)
                {
                    var symbol = foodSymbols[random.Next(foodSymbols.Length)];
                    int x, y;
                    do
                    {
                        x = random.Next(1, consoleWidth - 1); // Еда не может появиться на границе
                        y = random.Next(1, consoleHeight - 1); // Еда не может появиться на границе
                    }
                    while (snake.Contains((x, y))); // Еда не может появиться на месте змейки

                    int distanceFromBorder = Math.Min(x, consoleWidth - x - 1) + Math.Min(y, consoleHeight - y - 1);
                    int lifetime = random.Next(45, 121); // Время жизни еды от 45 до 120 секунд
                    int foodPoints = Math.Max(50 + (120 - lifetime) * 5 + (10 - distanceFromBorder) * 5, 0); // Чем меньше время жизни, тем больше очков
                    food.Add((symbol, x, y, foodPoints, lifetime));
                }

                // Обновляем таймеры еды
                for (int i = 0; i < food.Count; i++)
                {
                    food[i] = (food[i].symbol, food[i].x, food[i].y, food[i].foodPoints, food[i].lifetime - 1);
                }

                var head = snake.First();
                var newHead = (x: head.x + direction.dx, y: head.y + direction.dy);

                // Проверка столкновений
                if (newHead.x <= 0 || newHead.x >= consoleWidth - 1 ||
                    newHead.y <= 0 || newHead.y >= consoleHeight - 1 ||
                    snake.Skip(1).Contains(newHead))
                {
                    isRunning = false;
                    Console.Clear();
                    Console.WriteLine("Вы проиграли! Нажмите любую клавишу для выхода...");
                    Console.ReadKey();
                    break;
                }

                snake.Insert(0, newHead);

                // Проверка еды
                var eatenFood = food.FirstOrDefault(f => f.x == newHead.x && f.y == newHead.y);
                if (eatenFood != default)
                {
                    totalPoints += eatenFood.foodPoints; // Начисляем очки за съеденную еду
                    food.Remove(eatenFood); // Убираем съеденную еду с поля
                }
                else
                {
                    snake.RemoveAt(snake.Count - 1); // Удаляем последний элемент змейки
                }

                Console.Clear();
                DrawBorder();
                DrawSnake(snake, direction);
                foreach (var f in food) DrawFood(f);

                DrawScore(totalPoints, food, speed);

                // Проверка на победу
                if (totalPoints >= 999)
                {
                    isRunning = false;
                    Console.Clear();
                    Console.WriteLine("Вы выиграли! Набрано 999 очков!");
                    Console.ReadKey();
                    break;
                }
            }

            Thread.Sleep(speed);

            while (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow when direction.dy != 1:
                        direction = (0, -1); // Изменяем направление вверх
                        break;
                    case ConsoleKey.DownArrow when direction.dy != -1:
                        direction = (0, 1); // Изменяем направление вниз
                        break;
                    case ConsoleKey.LeftArrow when direction.dx != 1:
                        direction = (-1, 0); // Изменяем направление влево
                        break;
                    case ConsoleKey.RightArrow when direction.dx != -1:
                        direction = (1, 0); // Изменяем направление вправо
                        break;
                    case ConsoleKey.Spacebar:
                        isPaused = !isPaused; // Пауза игры
                        break;
                    case ConsoleKey.Escape:
                        isRunning = false; // Завершаем игру
                        break;
                    case ConsoleKey.PageUp:
                        if (speed > 50) speed -= 10; // Уменьшаем задержку для увеличения скорости
                        break;
                    case ConsoleKey.PageDown:
                        if (speed < 500) speed += 10; // Увеличиваем задержку для уменьшения скорости
                        break;
                }
            }
        }
    }

    static bool SetConsoleDimensions()
    {
        consoleWidth = Console.WindowWidth;
        consoleHeight = Console.WindowHeight - 1; // Минус одна строка для очков
        return consoleWidth >= 20 && consoleHeight >= 10;
    }

    static void DrawBorder()
    {
        Console.SetCursorPosition(0, 0);
        Console.Write('╔' + new string('═', consoleWidth - 2) + '╗');
        for (int y = 1; y < consoleHeight - 1; y++)
        {
            Console.SetCursorPosition(0, y);
            Console.Write('║');
            Console.SetCursorPosition(consoleWidth - 1, y);
            Console.Write('║');
        }
        Console.SetCursorPosition(0, consoleHeight - 1);
        Console.Write('╚' + new string('═', consoleWidth - 2) + '╝');
    }

    static void DrawSnake(List<(int x, int y)> snake, (int dx, int dy) direction)
    {
        char headSymbol = direction switch
        {
            (0, -1) => '▲', // Вверх
            (0, 1) => '▼', // Вниз
            (-1, 0) => '◄', // Влево
            (1, 0) => '►', // Вправо
            _ => 'O'
        };

        var head = snake.First();
        Console.SetCursorPosition(head.x, head.y);
        Console.Write(headSymbol);

        for (int i = 1; i < snake.Count; i++)
        {
            var current = snake[i];
            Console.SetCursorPosition(current.x, current.y);
            Console.Write('o'); // Тело змейки
        }
    }

    static void DrawFood((string symbol, int x, int y, int foodPoints, int lifetime) food)
    {
        Console.SetCursorPosition(food.x, food.y);
        Console.Write(food.symbol);
    }

    static void DrawScore(int totalPoints, List<(string symbol, int x, int y, int foodPoints, int lifetime)> food, int speed)
    {
        Console.SetCursorPosition(0, consoleHeight);
        Console.Write($"[Очки: {totalPoints}] ");
        Console.Write($"[Скорость: {500 - speed}] "); // Скорость отображается как 500 - задержка
        foreach (var f in food)
        {
            Console.Write($"[{f.symbol}: {f.foodPoints} очков, осталось {f.lifetime}с] ");
        }
    }
}
