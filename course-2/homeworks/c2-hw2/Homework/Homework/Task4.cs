class Task4
{
    public static void Run()
    {
        int a = 12;
        int b = 5;
        Console.WriteLine("a=12; b=5");

        Console.WriteLine($"Сумма({a}+{b})= {a + b}");

        Console.WriteLine($"Разность({a}-{b})={a - b}");
        Console.WriteLine($"Разность({b}-{a})={b - a}");

        Console.WriteLine($"Произведение({a}*{b})={a * b}");

        Console.WriteLine($"Остаток от деления({a}/{b})={a % b}");
        Console.WriteLine($"Остаток от деление({b}/{a})={b % a}");
    }
}
