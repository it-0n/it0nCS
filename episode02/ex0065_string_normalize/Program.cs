using System.Text;

class Program
{
    static void Main()
    {
        // Оригинальная строка: "e" + надстрочная отметка
        string original = "e\u0301";
        WriteLine("Оригинальная строка: " + original);
        WriteLine("Длина строки: " + original.Length);

        // Нормализация по умолчанию (FormC)
        string normalizedC = original.Normalize();
        WriteLine("\nНормализовано (FormC): " + normalizedC);
        WriteLine("Длина строки (FormC): " + normalizedC.Length);

        // Нормализация в FormD
        string normalizedD = original.Normalize(NormalizationForm.FormD);
        WriteLine("\nНормализовано (FormD): " + normalizedD);
        WriteLine("Длина строки (FormD): " + normalizedD.Length);

        // Нормализация в FormKC
        string normalizedKC = original.Normalize(NormalizationForm.FormKC);
        WriteLine("\nНормализовано (FormKC): " + normalizedKC);
        WriteLine("Длина строки (FormKC): " + normalizedKC.Length);

        // Нормализация в FormKD
        string normalizedKD = original.Normalize(NormalizationForm.FormKD);
        WriteLine("\nНормализовано (FormKD): " + normalizedKD);
        WriteLine("Длина строки (FormKD): " + normalizedKD.Length);

        // Сравнение строк
        WriteLine("\nСравнение:");
        WriteLine("original == normalizedC: " + (original == normalizedC));
        WriteLine("original == normalizedD: " + (original == normalizedD));
    }
}