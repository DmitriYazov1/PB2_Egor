class Task6
{
    public static void Run()
    {
        Console.WriteLine("Введите 2 числа: ");
        double a=Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Сумма: {a+b}");
    }
}
