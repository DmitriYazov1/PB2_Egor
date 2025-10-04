class Task7
{
    public static void Run()
    {
        Console.WriteLine("Ввведите ширину и длину прямоугольника:");
        double weigh=Convert.ToDouble(Console.ReadLine());
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Площадь: {weigh+height}");
    }
}