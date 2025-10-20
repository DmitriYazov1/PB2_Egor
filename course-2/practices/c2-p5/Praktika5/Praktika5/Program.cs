class Task1
{
    public static void Run()
    {
        Console.WriteLine($"3!={F(3)}");
        Console.WriteLine($"5!={F(5)}");
        Console.WriteLine($"7!={F(7)}");
    }
    static int F(int n)
    {
        if (n == 1) return 1;
        return F(n-1)*n; 
    }
}
class Task2
{
    public static void Run()
    {
        string a = "";

        for (int i = 0; i < 10; i++)
        {
            a += Convert.ToString(Fibonachi(i)) + " ";
        }
        Console.WriteLine($"Числа Фибоначчи от 1 до 10: {a}");
    }
    static int Fibonachi(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return Fibonachi(n - 1) + Fibonachi(n-2);
    }
        
}

class Task3
{
    public static void Run()
    {
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"Сумма чисел от 1 до {a}: {Gauss(a)}");
    }


    static int Gauss(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return Gauss(n - 1) + n;
    }
}

class Task4
{
    public static void Run()
    {
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Console.WriteLine("Понедельник");
                break;
            case "2":
                Console.WriteLine("Вторник");
                break;
            case "3":
                Console.WriteLine("Среда");
                break;
            case "4":
                Console.WriteLine("Четверг");
                break;
            case "5":
                Console.WriteLine("Пятница");
                break;
            case "6":
                Console.WriteLine("Суббота");
                break;
            case "7":
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("Неверный номер дня");
                break;

        }

    }
}
class Task5
{
    public static void Run()
    {
        Console.WriteLine("Введите 1 число: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите 2 число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите тип операции(+ - * /): ");
        string type = Console.ReadLine();


        Console.WriteLine($"{a} {type} {b} = {Calc(a, b, type)}");
        


    }
    static double Calc(double a, double b, string type)
    {
        switch (type)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                if (b == 0)
                {
                    Console.WriteLine("Error");
                    return 0;
                }
                return a / b;

            default:
                Console.WriteLine("Error");
                return 0;
        }
    }
}

class Task6
{
    public static void Run()
    {
        string num = Console.ReadLine();

        Console.WriteLine($"{num} = {Loto(num)}");
    }
    static string Loto(string num)
    {
        switch (num)
        {
            case "69":
                return "туда - сюда";
            case "77":
                return "топорики";
            case "80":
                return "бабушка";
            case "81":
                return "бабка с клюшкой";
            case "85":
                return "перестройка";
            case "88":
                return "крендельки";
            case "89":
                return "дедушкин сосед";
            default:
                return "Ничего не найдено ";
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




