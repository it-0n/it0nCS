class VerbatimAndInterpolationDemo
{
    static void Main()
    {
        string userName = "Alex";
        string projectName = "SuperProject";
        string fileName = "results.csv";

        // Формирование файлового пути
        string filePath = $@"C:\Users\{userName}\Projects\{projectName}\{fileName}";

        // Вывод сообщения о сохранении
        string message = $@"
Привет, {userName}!
Ваш проект '{projectName}' был успешно сохранён.
Путь к файлу: {filePath}
Пожалуйста, проверьте содержимое файла.";

        WriteLine(message);
    }
}