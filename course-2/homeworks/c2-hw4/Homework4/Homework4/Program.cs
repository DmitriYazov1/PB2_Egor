class Task1
{
    public static void Run()
    {
        int[] numbers = { 2, 4, 6, 8 };
        double average = Average(numbers);
        Console.WriteLine($"Среднее арифметическое массива: {average}");
    }

    static double Average(int[] numbers)
    {
       
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return (double)sum / numbers.Length;
    }
}

class Task2
{
    public static void Run()
    {
        while (true)
        {
            Console.Write("Введите первое число (или exit): ");
            string input1 = Console.ReadLine();

            if (input1 == "exit")
                break;

            Console.Write("Введите знак операции (или exit)(+, -, *, /): ");
            string operation = Console.ReadLine();
            if (operation == "exit")
                break;

            Console.Write("Введите второе число(или exit): ");
            string input2 = Console.ReadLine();
            if (input2 == "exit")
                break;

            double num1 = Convert.ToDouble(input1);
            double num2 = Convert.ToDouble(input2);

            

            if (operation == "+")
                Console.WriteLine($"Результат: {Add(num1, num2)}");
            else if (operation == "-")
                Console.WriteLine($"Результат: {Subtract(num1, num2)}");
            else if (operation == "*")
                Console.WriteLine($"Результат: {Multiply(num1, num2)}");
            else if (operation == "/")
                if (num2 == 0)
                {
                    Console.WriteLine("Error");

                }
                else
                {
                    Console.WriteLine($"Результат: {Divide(num1, num2)}");
                }

        }

        Console.WriteLine("Программа завершена");
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
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