class Task1
{
    public static void Run()
    {
        string a = "";
        for (int i = 0; i < 10; i++)
        {
            a += i;
        }
        Console.WriteLine(a);
    }
}

class Task2
{
    public static void Run() {
        int a = 0;
        for (int i = 0; i <= 100; i++)
        {
            a += i;
        }
        Console.WriteLine(a);
    } }

class Task3
{
    public static void Run()
    {
        Random random = new Random();
        int a = random.Next(1, 11);
        int b = 0;
        while (b != a)
        {
            b = Convert.ToInt16(Console.ReadLine());
        }
        Console.WriteLine("Верное число");
    }
}

class Task4
{
    public static void Run()
    {
        string a;
        do
        {
            a = Console.ReadLine();
        }
        while (a != "1234");
    }
}

class Task5
{
    public static void Run()
    {
        string[] city = { "Мадрид", "Анкара", "Стокгольм", "Оттава", "Мурманск" };
        foreach (string s in city)
        {
            Console.WriteLine(s);
        }
    }
}

class Task6
{
    public static void Run()
    {
        
        for (int i = 0;i <= 20; i++)
        {
            if (i % 2 != 0){
                continue;
            }
            Console.WriteLine(i);
            
        }
    }
}

class Task7
{
    public static void Run()
    {
        string a;
        int b = 0;

        while (true)
        {
            a = Console.ReadLine();

            if (a == "1234")
            {
                Console.WriteLine("Доступ разрешён");
                break;
            }

            else
            {
                b++;
                if (b >= 3)
                {
                    Console.WriteLine("Доступ запрещён");
                    break;
                }
            }

        }
    }
}

class Task8
{
    public static void Run()
    {
        
        string a = "";
        for (int i = 1; i <= 5; i++)
        {

            for (int j = 1; j <= 5; j++)
            {
                
                a += Convert.ToString(j*i) + " ";
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