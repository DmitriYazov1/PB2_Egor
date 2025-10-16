using System.Security.Cryptography.X509Certificates;

class Task1
{
    public static void Run()
    {
        void SayHello()
        {
            Console.WriteLine("Привет, Мир!");
        }

        for (int i = 0; i < 3; i++)
        {
            SayHello();
        }

    }
}

class Task2
{
    public static void Run()
    {
        void Greed(string name)
        {
            Console.WriteLine($"Привет, {name}!");

        }
        Greed("Саша");
        Greed("Ярослав");
        Greed("Анна");
    }
}

class Task3
{
    public static void Run()
    {
        void Print_Person(string name, int age, string city)
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}, Возраст: {city}");
        }
        Print_Person("Саша", 16, "Москва");
        Print_Person("Ярослав", 15, "Чита");

    }
    
}

class Task4
{
    public static void Run()
    {
        void Print_Person(string name, int age = 18, string hobby = "Не указано")
        {
            Console.WriteLine($"Имя:{name}, Возраст: {age}, Хобби: {hobby}");
        }
        Print_Person("Саша");
    }
}

class Task5
{
    public static void Run()
    {
        int Square(int a)
        {
            return a * a;
        }
        Console.WriteLine(Square(17));
    }
}

class Task6
{
    public static void Run()
    {
        string Add(int a, int b)
        {
            return $"{a}+{b}={a + b}";
        }
        string Subtract(int a, int b)
        {
            return $"{a}-{b}={a - b}";
        }
        string Multiply(int a, int b)
        {
            return $"{a}*{b}={a * b}";
        }
        string Divide(int a, int b)
        {
            return $"{a}/{b}={a / b}";
        }


        Console.WriteLine("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите знак операции(+ - * /): ");
        string type = Console.ReadLine();


        if (type == "+")
        {
            Console.WriteLine(Add(a, b));
        }
        else if (type == "-")
        {
            Console.WriteLine(Subtract(a, b));
        }
        else if (type == "*")
        {
            Console.WriteLine(Multiply(a, b));
        }
        else if (type == "/")
        {
            Console.WriteLine(Divide(a, b));
        }
    }
}

class Task7
{
    public static void Run()
    {
        int counter = 0;
        void Increment()
        {
            counter++;
        }

        for (int i = 0; i < 4; i++)
        {
            Increment();
            Console.WriteLine(counter);
        }
    }
}

class Task8
{
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static int Multiply(int a, int b, int c)
    {
        return a * b;
    }
    static double Multiply(double a, double b)
        {
            return a * b;
        }
    public static void Run()
    {
        Console.WriteLine(Multiply(2, 3));
        Console.WriteLine(Multiply(2, 3, 4));
        Console.WriteLine(Multiply(2.5, 4.0));

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


            if (number > 8 || number < 0)
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