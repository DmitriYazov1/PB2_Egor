class Task3
{
    public static void Run()
    {
        Console.WriteLine("Введите 2 числа:");
        double a =Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Сумма({a}+{b})= {a+b}");

        Console.WriteLine($"Разность({a}-{b})={a-b}");
        Console.WriteLine($"Разность({b}-{a})={b - a}");

        Console.WriteLine($"Произведение({a}*{b})={a * b}");

        Console.WriteLine($"Частное({a}/{b})={a / b}");
        Console.WriteLine($"Частно({b}/{a})={b / a}");



    }
}
