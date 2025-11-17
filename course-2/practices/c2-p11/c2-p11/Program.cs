//1
class Animal
{
   public virtual void MakeSound()
    {
        Console.WriteLine("Животное издаёт звук");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Гав");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Мяу");
    }
}

class Cow : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Му");
    }
}

//2

class Transport
{
    public string Model {  get; set; }
    public virtual void Move()
    {
        Console.WriteLine($"{Model}: транспорт движется.");

    }
}
class Car : Transport
{
    public override void Move()
    {
        base.Move();
        Console.WriteLine("Машина едет по дороге");
    }
}

class Boat : Transport
{
    public override void Move()
    {
        base.Move();
        Console.WriteLine("Лодка плывёт по воде");
    }
}

class Plane : Transport
{
    public override void Move()
    {
        base.Move();
        Console.WriteLine("Самолёт летит в небе");
    }
}

//3

public abstract class Shape
{
    public abstract double GetArea();
    
}
class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Square : Shape
{
    public double Side { get; set; }

    public override double GetArea()
    {
        return Side * Side;
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

//4


class Instrument
{
    public virtual void Play()
    {
        Console.WriteLine("Инструмент издаёт звук");
    }
}

class Guitar : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Гитара играет аккорды");
    }
}

class Piano : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Пианино играет мелодию");
    }
}

class Drum : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Барабан бьёт ритм");
    }
}

//5

public abstract class Character
{
    public string Name { get; set; }
    public abstract void Attack();
}

class Warrior : Character
{
    public override void Attack()
    {
        Console.WriteLine("Воин атакует мечом!");
    }
}

class Mage : Character
{
    public override void Attack()
    {
        Console.WriteLine("Маг выпускает огненный шар!");
    }
}

class Archer : Character
{
    public override void Attack()
    {
        Console.WriteLine("Лучник стреляет из лука!");
    }
}


class Program
{
    static void Main()
    {
        

        
        //3
        Shape[] shapes =
        {
            new Circle { Radius = 5 },
            new Square { Side = 4 },
            new Rectangle { Width = 3, Height = 6 }
        };
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
        }


        //4
        Instrument[] instruments = { new Guitar(), new Piano(), new Drum() };
        foreach (var instrument in instruments)
        {
            instrument.Play();
        }

        //5
        Character[] team =
        {
            new Warrior { Name = "Алекс" },
            new Mage { Name = "Лия" },
            new Archer { Name = "Робин" }
        };
        foreach (var character in team)
        {
            Console.Write($"{character.Name}: ");
            character.Attack();
        }
    }
}