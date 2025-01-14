using System.Text;

class Program
{
    static void Main()
    {
        // Исходные строки
        string original = "e\u0301"; // "e" + надстрочная отметка
        string normalized = original.Normalize(); // Приведено к FormC

        WriteLine("Исходная строка: " + original);
        WriteLine("Нормализованная строка (FormC): " + normalized);

        // Проверка нормализации по умолчанию (FormC)
        WriteLine("\nПроверка нормализации (FormC):");
        WriteLine("original.IsNormalized(): " + original.IsNormalized());
        WriteLine("normalized.IsNormalized(): " + normalized.IsNormalized());

        // Проверка нормализации в FormD
        WriteLine("\nПроверка нормализации (FormD):");
        WriteLine("original.IsNormalized(FormD): " + original.IsNormalized(NormalizationForm.FormD));
        WriteLine("normalized.IsNormalized(FormD): " + normalized.IsNormalized(NormalizationForm.FormD));

        // Проверка нормализации в FormKC
        WriteLine("\nПроверка нормализации (FormKC):");
        WriteLine("original.IsNormalized(FormKC): " + original.IsNormalized(NormalizationForm.FormKC));
        WriteLine("normalized.IsNormalized(FormKC): " + normalized.IsNormalized(NormalizationForm.FormKC));
    }
}