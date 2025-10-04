class Task1
{
    
    public static void Run() 
    {
        
        Console.WriteLine("Температура в градусах Цельсия: ");

        var input = Console.ReadLine();

        double C = Convert.ToDouble(input);

        double F = C * 9 / 5 + 32;
        
        Console.WriteLine($"Температура в градусах Фаренгейта: {F}");

}
    
}