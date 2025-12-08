class Program
{
    static void Main()
    {
        //  1
        var movies = new List<string>();

        movies.Add("Матрица");
        movies.Add("Начало");
        movies.Add("Интерстеллар");

        Console.WriteLine("Фильмы в списке:");
        foreach (var m in movies)
            Console.WriteLine(m);

        movies.Remove("Начало");

        Console.WriteLine("\nПосле удаления:");
        foreach (var m in movies)
            Console.WriteLine(m);
        Console.WriteLine($"Всего фильмов: {movies.Count}");

        Console.WriteLine();

        //  2
        var numbers = new List<int> { 12, 5, 8, 19, 3 };

        Console.WriteLine("Исходный список: " + string.Join(" ", numbers));

        numbers.Sort();
        Console.WriteLine("Отсортированный: " + string.Join(" ", numbers));

        int min = numbers[0];
        int max = numbers[^1];
        Console.WriteLine($"Минимум: {min}, Максимум: {max}");

        numbers.Reverse();
        Console.WriteLine("После Reverse: " + string.Join(" ", numbers));

        Console.WriteLine();

        //  3
        var phoneBook = new Dictionary<string, string>();

        phoneBook.Add("Анна", "8921-123-45-67");
        phoneBook.Add("Иван", "8931-555-77-88");
        phoneBook.Add("Ольга", "8905-111-22-33");

        string name = "Иван";
        if (phoneBook.ContainsKey(name))
            Console.WriteLine($"Телефон {name}: {phoneBook[name]}");

        name = "Пётр";
        if (phoneBook.TryGetValue(name, out var phone))
            Console.WriteLine($"Телефон {name}: {phone}");
        else
            Console.WriteLine($"Контакт {name} не найден");

        Console.WriteLine();

        //  4
        var grades = new Dictionary<string, List<int>>
        {
            { "Анна", new List<int> { 5, 4, 5 } },
            { "Иван", new List<int> { 3, 4, 4 } }
        };

        foreach (var kv in grades)
        {
            string student = kv.Key;
            var list = kv.Value;

            double sum = 0;
            foreach (var grade in list)
                sum += grade;
            double avg = sum / list.Count;

            Console.WriteLine($"{student} -- средний балл: {avg:F2}");
        }
    }
}