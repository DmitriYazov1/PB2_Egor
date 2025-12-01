class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Год: {Year}");
    }
}

class Account
{
    private decimal balance;

    public decimal Balance => balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
    }
}

class Transport
{
    public virtual void Move()
    {
        Console.WriteLine("Транспорт движется.");
    }
}

class Car : Transport
{
    public override void Move()
    {
        Console.WriteLine("Машина едет по дороге");
    }
}

class Boat : Transport
{
    public override void Move()
    {
        Console.WriteLine("Лодка плывёт по воде");
    }
}

class Plane : Transport
{
    public override void Move()
    {
        Console.WriteLine("Самолёт летит в небе");
    }
}

class Animal
{
    private int _energy = 100;

    public void Eat()
    {
        ChangeEnergy(10);
        Console.WriteLine("Животное поело");
    }

    public void ShowEnergy()
    {
        Console.WriteLine($"Энергия: {_energy}");
    }

    protected void ChangeEnergy(int delta)
    {
        _energy += delta;
        if (_energy < 0) _energy = 0;
        if (_energy > 150) _energy = 150;
    }
}

class Dog : Animal
{
    public void Run()
    {
        ChangeEnergy(-20);
        Console.WriteLine("Собака побежала");
    }
}

class Cat : Animal
{
    public void Sleep()
    {
        ChangeEnergy(5);
        Console.WriteLine("Кошка поспала");
    }
}

class Shape
{
    public virtual double GetArea()
    {
        return 0;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double GetArea()
    {
        return Width * Height;
    }
}

abstract class Worker
{
    public string Name { get; set; }

    public abstract void Work();

    public void ShowInfo()
    {
        Console.WriteLine($"Работник: {Name}");
    }
}

class Manager : Worker
{
    public override void Work()
    {
        Console.WriteLine("Планирует задачи");
    }
}

class Developer : Worker
{
    public override void Work()
    {
        Console.WriteLine("Пишет код");
    }
}

interface IPlayable
{
    void Play();
}

class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Гитара играет аккорды");
    }
}

class Piano : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Пианино играет мелодию");
    }
}

class Drum : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Барабан отбивает ритм");
    }
}

interface IPrinter
{
    void Process();
}

interface IScanner
{
    void Process();
}

class MultifunctionDevice : IPrinter, IScanner
{
    void IPrinter.Process()
    {
        Console.WriteLine("Печать документа...");
    }

    void IScanner.Process()
    {
        Console.WriteLine("Сканирование документа...");
    }
}

interface IDocumentExporter
{
    string FormatName { get; }
    void Export(string content);

    void ShowInfo(string content)
    {
        Console.WriteLine($"Экспорт в формат {FormatName}: {content}");
    }
}

class TxtExporter : IDocumentExporter
{
    public string FormatName => "TXT";

    public void Export(string content)
    {
        Console.WriteLine("Сохраняем текстовый файл...");
    }
}

class PdfExporter : IDocumentExporter
{
    public string FormatName => "PDF";

    public void Export(string content)
    {
        Console.WriteLine("Создаём PDF-документ...");
    }
}

abstract class MenuItem
{
    public string Name { get; set; }
    public abstract double GetPrice();
}

interface IOrderItem
{
    void PrintInfo();
}

class Drink : MenuItem, IOrderItem
{
    public int Volume { get; set; }

    public override double GetPrice()
    {
        return Volume * 0.05;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Блюдо: {Name}, Цена: {GetPrice():F2}");
    }
}

class Food : MenuItem, IOrderItem
{
    public int Weight { get; set; }

    public override double GetPrice()
    {
        return Weight * 0.02;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Блюдо: {Name}, Цена: {GetPrice():F2}");
    }
}

class Program
{
    static void Main()
    {
        var book = new Book { Title = "Война и мир", Author = "Л. Толстой", Year = 1869 };
        book.ShowInfo();

        Console.WriteLine();

        var acc = new Account();
        acc.Deposit(1000);
        acc.Withdraw(300);
        Console.WriteLine(acc.Balance);

        Console.WriteLine();

        Transport[] transports = { new Car(), new Boat(), new Plane() };
        foreach (var t in transports)
            t.Move();

        Console.WriteLine();

        var dog = new Dog();
        dog.ShowEnergy();
        dog.Run();
        dog.ShowEnergy();
        dog.Eat();
        dog.ShowEnergy();

        var cat = new Cat();
        cat.ShowEnergy();
        cat.Sleep();
        cat.ShowEnergy();
        cat.Eat();
        cat.ShowEnergy();

        Console.WriteLine();

        Shape[] shapes =
        {
            new Circle { Radius = 3 },
            new Rectangle { Width = 4, Height = 5 }
        };
        foreach (var s in shapes)
            Console.WriteLine(s.GetArea());

        Console.WriteLine();

        Worker[] workers = { new Manager { Name = "Анна" }, new Developer { Name = "Иван" } };
        foreach (var w in workers)
        {
            w.ShowInfo();
            w.Work();
        }

        Console.WriteLine();

        IPlayable[] instruments = { new Guitar(), new Piano(), new Drum() };
        foreach (var i in instruments)
            i.Play();

        Console.WriteLine();

        var device = new MultifunctionDevice();
        ((IPrinter)device).Process();
        ((IScanner)device).Process();

        Console.WriteLine();

        IDocumentExporter[] exporters = { new TxtExporter(), new PdfExporter() };
        foreach (var e in exporters)
        {
            e.ShowInfo("Hello world!");
            e.Export("Hello world!");
        }

        Console.WriteLine();

        IOrderItem[] order =
        {
            new Drink { Name = "Кофе", Volume = 200 },
            new Food { Name = "Сэндвич", Weight = 250 }
        };

        double total = 0;
        foreach (var item in order)
        {
            item.PrintInfo();
            total += ((MenuItem)item).GetPrice();
        }
        Console.WriteLine($"Общая сумма: {total:F2}");
    }
}