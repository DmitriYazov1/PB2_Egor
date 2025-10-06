class Task1
{
    public static void Run()
    {
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine($"{number}>0");
        }
        else if (number < 0)
        {
            Console.WriteLine($"{number}<0");
        }
        else
        {
            Console.WriteLine($"{number}=0");
        }
    }
}

class Task2
{
    public static void Run()
    {
        int age = Convert.ToInt32(Console.ReadLine());
        if (age > 0)
        {
            if (age >= 18)
            {
                Console.WriteLine("Совершеннолетний");

            }
            else
            {
                Console.WriteLine("Несовершеннолетний");
            }
        }
    }
}

class Task3
{
    public static void Run()
    {
        int number = 7;
        if (number % 2 == 0)
        {
            Console.WriteLine("Число четно");

        }
        else
        {
            Console.WriteLine("Число нечетно");
        }
    }
}

class Task4
{
    public static void Run()
    {
        int a = 5;
        int b = -2;
        if (a > 0 && b > 0)
        {
            Console.WriteLine("Оба числа положительны");
        }
        if (a > 0 || b > 0)
        {
            Console.WriteLine("Одно положительно");

        }
        if (a<0)
        {
            Console.WriteLine($"{a} отрицательно");
            
        }
    }
}

class Task5
{
    public static void Run()
    {
        int grade;
        grade = Convert.ToInt32(Console.ReadLine());
        if (grade < 3)
        {
            Console.WriteLine("");
        }
        else if (grade == 3)
        {
            Console.WriteLine("Удовлетворительно");
        }
        else if (grade == 4)
        {
            Console.WriteLine("Хорошо");
        }
        else if (grade == 5)
        {
            Console.WriteLine("Отлично");
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


            if (number > 5 || number < 0)
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