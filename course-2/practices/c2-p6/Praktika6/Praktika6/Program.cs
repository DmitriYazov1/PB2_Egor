using System.Diagnostics.Tracing;

class Task1
{
    public static void Run()
    {
        const double Dollar = 0.012247;
        const double Euro = 0.010554;
        const double Uani = 0.087305;

        Console.Write("Введите сумму в рублях: ");
        double rubles = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите валюту для перевода:");
        Console.WriteLine("1 — Доллары");
        Console.WriteLine("2 — Евро");
        Console.WriteLine("3 — Юани");

        int choice = Convert.ToInt32(Console.ReadLine());
        double result;
        string currencySymbol;

        switch (choice)
        {
            case 1:
                result = rubles * Dollar;
                currencySymbol = "$";
                break;
            case 2:
                result = rubles * Euro;
                currencySymbol = "€";
                break;
            case 3:
                result = rubles * Uani;
                currencySymbol = "¥";
                break;
            default:
                Console.WriteLine("Некорректный выбор валюты");
                return;
        }

        Console.WriteLine($"{rubles} руб. = {result} {currencySymbol}");
    }
}

class Task2
{
    public static void Run()
    {
        Console.Write("Введите текущее время (час, от 0 до 23): ");
        int hour = Convert.ToInt32(Console.ReadLine());

        string timeOfDay;

        if (hour >= 0 && hour <= 5)
            timeOfDay = "Ночь";
        else if (hour >= 6 && hour <= 11)
            timeOfDay = "Утро";
        else if (hour >= 12 && hour <= 17)
            timeOfDay = "День";
        else if (hour >= 18 && hour <= 23)
            timeOfDay = "Вечер";
        else
            timeOfDay = "Некорректный ввод";

        Console.WriteLine(timeOfDay);
    }
}

class Task3
{
    public static void Run()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;

        for (int i =10;  i < number; i += 10)
        {
            count++;
        }
        Console.WriteLine($"Количесвто чисел: {count}");
    }
}

class Task4
{
    public static void Run()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
                min = numbers[i];

            if (numbers[i] > max)
                max = numbers[i];
        }

        Console.WriteLine($"Минимум: {min}");
        Console.WriteLine($"Максимум: {max}");
    }
}


class Task5
{
    static bool Having(char a, char[] b)
    {
        foreach (char word in b)
        {
            if (a == word)
            {
                return true;
            }
        }
        return false;
    }
    public static void Run()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        char[] glas = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
        

        int vowelCount = 0;
        int consonantCount = 0;

        foreach (char letter in word)
        {
            if (Having(letter, glas))
            {
                vowelCount++;
            }
            else 
            {
                consonantCount++;
            }
        }

        Console.WriteLine($"Гласных: {vowelCount}");
        Console.WriteLine($"Согласных: {consonantCount}");
    }
}

class Task6
{
    public static void Run()
    {
        int yesCount = 0;
        Console.WriteLine("Любите ли вы программировать? (1 — Да, 0 — Нет)");

        yesCount+= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Работаете ли вы в команде? (1 — Да, 0 — Нет)");

        yesCount += Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Хотите ли стать разработчиком? (1 — Да, 0 — Нет)");

        yesCount += Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Вы ответили Да на {yesCount} из 3 вопросов");
    }
}

class Task7
{
    public static void Run()
    {
        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        CheckPassword(password);
    }

    static void CheckPassword(string pass)
    {
        bool hasLength = pass.Length >= 8;
        bool hasDigit = false;
        bool hasUpper = false;

        foreach (char c in pass)
        {
            if (char.IsDigit(c))
                hasDigit = true;
            if (char.IsUpper(c))
                hasUpper = true;
        }

        if (hasLength && hasDigit && hasUpper)
        {
            Console.WriteLine("Пароль надёжный");
        }
        else
        {
            Console.Write("Пароль ненадёжный: ");
            

            if (!hasLength)
                Console.Write(" слишком короткий ");
            if (!hasDigit)
                Console.Write(" не содержит цифр ");
            if (!hasUpper)
                Console.Write(" не содержит заглавных букв ");

            
        }
    }
}

class Task8
{
    public static void Run()
    {
        Console.Write("Введите n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

class Task9
{
    public static void Run()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine($"Сумма цифр: {SumDigits(number)}");
    }

    static int SumDigits(int n)
    {
        if (n < 10)
            return n;
        else
            return n % 10 + SumDigits(n / 10);
    }
}

class Task10
{
    public static void Run()
    {
        Console.Write("Введите количество дней: ");
        int days = Convert.ToInt32(Console.ReadLine());

        double[] temperatures = new double[days];

        for (int i = 0; i < days; i++)
        {
            Console.Write($"Введите температуру за день {i + 1}: ");
            temperatures[i] = Convert.ToDouble(Console.ReadLine());
        }

      
        

        Console.WriteLine($"Средняя температура: {AverageTemp(temperatures)}");
        Console.WriteLine($"Максимальная: {MaxTemp(temperatures)}");
        Console.WriteLine($"Дней выше среднего: {CountAboveAverage(temperatures)}");
    }

    static double AverageTemp(double[] temps)
    {
        double sum = 0;
        foreach (double temp in temps)
        {
            sum += temp;
        }
        return sum / temps.Length;
    }

    static double MaxTemp(double[] temps)
    {
        double max = temps[0];
        
        foreach(double temp in temps)
        {
            if (temp> max)
            {
                max = temp;
            }
        }
        return max;
    }

    static int CountAboveAverage(double[] temps)
    {
        double average = AverageTemp(temps);
        int count = 0;

        foreach (double temp in temps)
        {
            if (temp > average)
                count++;
        }
        return count;
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите номер задания или 0 для завершения программы: ");

            sbyte number = Convert.ToSByte(Console.ReadLine());

            if (number > 10 || number < 0)
            {
                Console.WriteLine("Недопустимое число");
            }
            else if (number == 0)
            {
                Console.WriteLine("Программа завершена ");
                break;
            }
            else
            {
                Type classType = Type.GetType($"Task{number}");
                System.Reflection.MethodInfo method = classType.GetMethod("Run");
                method.Invoke(null, null);
            }
        }
    }
}