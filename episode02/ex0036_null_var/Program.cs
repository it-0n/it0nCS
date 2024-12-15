class Program
{
    static void Main()
    {
        // Пример 1: bool? для статуса пользователя
        bool? isOnline = null; // Пользователь ещё не зашёл в чат
        WriteLine("Пользователь онлайн? " + (isOnline.HasValue ? isOnline.Value.ToString() : "Неизвестно"));

        // Меняем статус пользователя
        isOnline = true; // Пользователь зашёл в чат
        WriteLine("Пользователь онлайн? " + (isOnline.HasValue ? isOnline.Value.ToString() : "Неизвестно"));

        // Пример 2: int? для возраста
        int? userAge = null; // Возраст пользователя неизвестен
        WriteLine("Возраст пользователя: " + (userAge.HasValue ? userAge.Value.ToString() : "Не указан"));

        // Присваиваем значение
        userAge = 25; // Возраст стал известен
        WriteLine("Возраст пользователя: " + (userAge.HasValue ? userAge.Value.ToString() : "Не указан"));

        // Пример 3: double? для температуры
        double? temperature = null; // Температура не измерена
        WriteLine("Температура: " + (temperature.HasValue ? temperature.Value.ToString() + "°C" : "Неизвестна"));

        // Устанавливаем значение температуры
        temperature = 22.5; // Температура измерена
        WriteLine("Температура: " + (temperature.HasValue ? temperature.Value.ToString() + "°C" : "Неизвестна"));
    }
}
