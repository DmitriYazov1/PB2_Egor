class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine($"{Name} ест.");
    }

    public virtual void Speak()
    {
        Console.WriteLine("Животное издаёт звук");
    }

    public virtual void Move()
    {
        Console.WriteLine("Животное двигается.");
    }

    public Animal() {
        Name = "Нет";
    }
    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Создано животное: {Name}");
    }
}

class Dog: Animal
{
    
    public void Bark()
    {
        Console.WriteLine("Собака лает.");
    }

    public override void Speak()
    {
        Console.WriteLine("Собака говорит: Гав-гав!");
    }

    public override void Move()
    {
        base.Move();

        Console.WriteLine("Собака бежит по дороге.");
    }

    
}

class Cat: Animal
{
    public void Meow()
    {
        Console.WriteLine("Кошка мяукает.");
    }

    public override void Speak()
    {
        Console.WriteLine("Кошка говорит: Мяу!");
    }

    public Cat() : base()
    {

    }
    public Cat(string name) : base(name)
    {
        Console.WriteLine($"Создана кошка по имени {Name}");
    }

}


class Transport
{
    public virtual void Drive()
    {
        Console.WriteLine("Транспорт движется");
    }
}

class Car : Transport
{
    public override void Drive()
    {
        Console.WriteLine("Машина едет по дороге");
    }
}

class ElectricCar : Car
{
    public override void Drive()
    {
        Console.WriteLine("Электромобиль тихо едет на батарее");
    }
}


class Program
{
    static void Main()
    {
        var dog = new Dog();
        dog.Name = "Шарик";
        dog.Eat();
        dog.Bark();

        var cat = new Cat();
        cat.Name = "Мурка";
        cat.Eat();
        cat.Meow();

        Console.WriteLine();

        var dog2 = new Dog();
        var cat2 = new Cat();
        dog2.Speak();
        cat2.Speak();

        Console.WriteLine();

        var dog3 = new Dog();
        dog3.Move();

        Console.WriteLine();

        var cat4 = new Cat("Мурка");

        Console.WriteLine();

        var transport = new Transport();
        var car = new Car();
        var tesla = new ElectricCar();

        transport.Drive();
        car.Drive();
        tesla.Drive();
    }
}
