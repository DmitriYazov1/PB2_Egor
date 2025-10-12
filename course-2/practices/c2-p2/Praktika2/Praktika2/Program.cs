class Task1
{
    public static void Run()
    {
        Random random = new Random();
        int[] numbers = new int[5];
        foreach (int i in numbers)
        {
            numbers[i] = random.Next();
            Console.WriteLine(numbers[i]);
        }
    }
}

class Task2
{
    public static void Run()
    {
        Random random = new Random();
        int a = 0;

        int[] numbers = new int[6];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 5);
        }

        foreach (int number in numbers)
        {
            a += number;
        }

        Console.WriteLine($"Сумма: {a}");

        a = a / numbers.Length;

        Console.WriteLine($"Среднее арифметическое: {a}");

    }
}

class Task3
{
    public static void Run()
    {
        Random random = new Random();
        int a=0;
        int[] numbers= new int[8];

        for(int i = 0; i < numbers.Length;i++)
        {
            numbers[i] = random.Next(0, 100);
        }

        foreach(int number in numbers)
        {
            if (number>a){
                a= number;
            }
        }
        Console.WriteLine($"Наибольшее число:{a}");
    }
}

class Task4
{
    public static void Run()
    {
        Random random = new Random();
        int a = 0;
        int b = 0;
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next();
        }

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                a += 1;
            }
            else
            {
                b += 1;
            }
        }
        Console.WriteLine($"Четных:{a}. Нечетных:{b}");
    }
}

class Task5
{
    public static void Run()
    {
        string[] fruits = new string[5];
        Console.WriteLine("Введите фрукты: ");
        for (int i = 0; i < fruits.Length; i++)
        {
            fruits[i] = Console.ReadLine();
        }


        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}

class Task6
{
    public static void Run()
    {
        Random random = new Random();
        int[,] matrix = new int[3, 3];
        string a = "";

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(0, 9);
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                a = Convert.ToString(matrix[i, j]) + $" {a}";
            }
            Console.WriteLine(a);
            a = "";

        }
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


            if (number > 6 || number < 0)
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