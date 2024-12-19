namespace CakeBakery
{
    // Интерфейс, описывающий основные действия по приготовлению торта
    interface ICake
    {
        void Prepare();
        void Bake();
        void Decorate();
    }

    // Класс, представляющий торт
    class Cake : ICake
    {
        public string Name { get; set; }
        public string[] Ingredients { get; set; }

        public Cake(string name, string[] ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }

        public void Prepare()
        {
            WriteLine($"Готовим торт '{Name}' с ингредиентами: {string.Join(", ", Ingredients)}.");
        }

        public void Bake()
        {
            WriteLine($"Выпекаем торт '{Name}'.");
        }

        public void Decorate()
        {
            WriteLine($"Украшаем торт '{Name}'.");
        }
    }

    // Делегат, представляющий метод уведомления
    delegate void Notify(string message);

    // Запись, представляющая рецепт торта
    record Recipe(string Name, string[] Ingredients);

    class Program
    {
        static void Main(string[] args)
        {
            // Использование строки
            string cakeName = "Шоколадный торт";

            // Использование массива
            string[] ingredients = { "Мука", "Сахар", "Какао", "Кефир", "Масло" };

            // Создание экземпляра класса Cake
            ICake myCake = new Cake(cakeName, ingredients);

            // Использование делегата для уведомления
            Notify notifier = message => WriteLine($"[Уведомление]: {message}");

            // Динамический тип для хранения дополнительной информации
            dynamic additionalInfo = new System.Dynamic.ExpandoObject();
            additionalInfo.PreparationTime = "2 часа";
            additionalInfo.Difficulty = "Средний";

            // Использование записи для хранения рецепта
            Recipe cakeRecipe = new(cakeName, ingredients);

            // Процесс приготовления торта
            notifier("Начинаем процесс приготовления торта.");
            myCake.Prepare();
            myCake.Bake();
            myCake.Decorate();
            notifier($"Торт '{cakeRecipe.Name}' готов!");

            // Вывод дополнительной информации
            WriteLine($"Время приготовления: {additionalInfo.PreparationTime}");
            WriteLine($"Сложность: {additionalInfo.Difficulty}");

            // Использование типа object
            object cakeObject = myCake;
            WriteLine($"Тип объекта cakeObject: {cakeObject.GetType().Name}");
        }
    }
}