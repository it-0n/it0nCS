class Program
{
    static void Main()
    {
        // 1. Необработанный строковый литеральный текст
        var xml = """
        <element attr="content">
            <body>
            </body>
        </element>
        """;
        WriteLine("Raw String Literal Text (XML):");
        WriteLine(xml);

        var sqlQuery = """
        SELECT * 
        FROM Products
        WHERE Price > 1000
        ORDER BY Name;
        """;
        WriteLine("\nRaw String Literal Text (SQL):");
        WriteLine(sqlQuery);

        // 2. Необработанный строковый литерал с интерполяцией
        var person = new { FirstName = "Alice", Age = 25 };
        string json = $$"""
        {
          "first_name": "{{person.FirstName}}",
          "age": {{person.Age}},
          "calculation": "{{{ 5 + 3 }}}"
        }
        """;
        WriteLine("\nRaw String Literal with Interpolation (JSON):");
        WriteLine(json);

        string title = "Welcome!";
        string message = "Raw string literals in action.";
        var html = $$"""
        <html>
          <head><title>{{title}}</title></head>
          <body>
            <p>{{message}}</p>
            <p>Result of 10 * 2: {{{10 * 2}}}</p>
          </body>
        </html>
        """;
        WriteLine("\nRaw String Literal with Interpolation (HTML):");
        WriteLine(html);
    }
}