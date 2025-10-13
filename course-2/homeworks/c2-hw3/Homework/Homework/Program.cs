class Task1
{
    public static void Run()
    {
        Random random = new Random();
        int[] numbers = new int[7];
        int t = 0;
        int f = 0;
        int b = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(2, 6);
        }
        Console.WriteLine($"Список оценок: {string.Join(", ", numbers)}");

        foreach (int i in numbers)
        {
            if (i == 2)
            {
                t++;
            }
            else if (i == 5)
            {
                f++;
            }
            b += i;
            
        }
        Console.WriteLine($"Оценок 2: {t}");
        Console.WriteLine($"Оценок 5: {f}");
        Console.WriteLine($"Средний балл: {b / numbers.Length}");
    }
}

class Task2
{
    public static void Run()
    {
        Random random = new Random();

        int[] numbers = new int[5];
        int[] srebmun = new int[5];

        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(2, 5);
        }
        Console.WriteLine($"Изначальный список: {string.Join(", ", numbers)}");

        for (int i = 0; i < numbers.Length; i++)
        {
            srebmun[srebmun.Length - 1 - i] = numbers[i];
        }
        Console.WriteLine($"Перевернутый список: {string.Join(", ", srebmun)}");
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите номер задания или 0 для завершения програмы: ");

            sbyte number = Convert.ToSByte(Console.ReadLine());


            if (number > 2 || number < 0)
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