//1

abstract class Shape
{
   public abstract string Name{ get;  }
   public abstract double GetArea();

    public void Print()
    {
        Console.WriteLine($"{Name}: площадь = {GetArea()}");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public override string Name => "Круг";

    public override double GetArea() => Math.PI * Radius * Radius;
    

}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override string Name => "Прямоугольник";

    public override double GetArea() => Width * Height;

}

//2
abstract class Animal
{
    public string Name;
    public Animal(string name)
    {
        Name=name;
        Console.WriteLine($"Создано животное: {Name}");
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} ест.");
    }

    public abstract void MakeSound();
}
class Dog: Animal
{

    public Dog(string name) : base(name) { }
    
    

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Гав-гав!");
    }
}


class Cat : Animal
{

    public Cat(string name) : base(name) { }



    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Мяу!");
    }
}
//3

abstract class Transport
{
    protected void Start()
    {
        Console.WriteLine("Start");
    }

    protected void Stop()
    {
        Console.WriteLine("Stop");
    }

    protected abstract void MoveCore();
    public void Move()
    {
        Start(); 
        MoveCore(); 
        Stop();
    }
}
class Car : Transport
{
    protected override void MoveCore()
    {
        Console.WriteLine("Машина едет по дороге");
    }
}

class Boat : Transport
{
    protected override void MoveCore()
    {
        Console.WriteLine("Лодка плывёт по воде");
    }
}

// 
public abstract class DocumentExporter
{
    public abstract string FormatName { get; }
    public abstract void Export(string content);

    public void ShowInfo(string content)
    {
        Console.WriteLine($"Экспорт в формат {FormatName}: {content}");
    }
}

public class TxtExporter : DocumentExporter
{
    public override string FormatName => "TXT";

    public override void Export(string content)
    {
        Console.WriteLine("Сохраняем текстовый файл");
    }
}

public class PdfExporter : DocumentExporter
{
    public override string FormatName => "PDF";

    public override void Export(string content)
    {
        Console.WriteLine("Создаём PDF-документ");
    }
}

class Programm
{
    public void Main()
    {
        //1
        Shape[] shapes =
        {
            new Circle{Radius=5},
            new Rectangle{Width=5, Height=8},
        };

        foreach (Shape shape in shapes)
        {
            shape.Print();
        }
        //2
        Animal[] animals =
       {
            new Dog("Рекс"),
            new Cat("Мурка")
        };

        foreach (var animal in animals)
        {
            animal.Eat();
            animal.MakeSound();
        }
        //3
        Transport[] transports =
      {
            new Car(),
            new Boat()
        };

        foreach (var transport in transports)
        {
            transport.Move();
        }

        //4
        DocumentExporter[] exporters =
        {
            new TxtExporter(),
            new PdfExporter()
        };

        foreach (var exporter in exporters)
        {
            exporter.ShowInfo("Hello world!");
            exporter.Export("Hello world!");
        }
    }
}
