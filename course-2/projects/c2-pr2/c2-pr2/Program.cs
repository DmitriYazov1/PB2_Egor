


public abstract class Animal
{
    private int energy = 100;
    public string Name { get; set; }

    protected Animal(string name)
    {
        Name = name;
    }

    public void Eat()
    {
        ChangeEnergy(10);
        Console.WriteLine($"{Name} ест. Энергия: {energy}");
    }

    public void Rest()
    {
        ChangeEnergy(5);
        Console.WriteLine($"{Name} отдыхает. Энергия: {energy}");
    }

    public abstract void MakeSound();

    private void ChangeEnergy(int delta)
    {
        energy += delta;
        if (energy < 0) energy = 0;
        if (energy > 150) energy = 150;
    }
}

public class Dog : Animal
{
    public Dog() : base("Собака") { }
    public Dog(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Гав-гав!");
    }
}

public class Cat : Animal
{
    public Cat() : base("Кошка") { }
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Мяу!");
    }
}

public class Elephant : Animal
{
    public Elephant() : base("Слон") { }
    public Elephant(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Трууу!");
    }
}

public class Zoo
{
    private Animal[] animals;
    private int count = 0;

    public Zoo(int capacity)
    {
        if (capacity <= 0) capacity = 1;
        animals = new Animal[capacity];
    }

    public bool Add(Animal animal)
    {
        if (count >= animals.Length) return false;
        animals[count++] = animal;
        return true;
    }

    public void MakeAllSounds()
    {
        for (int i = 0; i < count; i++)
            animals[i].MakeSound();
    }

    public void FeedAll()
    {
        for (int i = 0; i < count; i++)
            animals[i].Eat();
    }

    public void RestAll()
    {
        for (int i = 0; i < count; i++)
            animals[i].Rest();
    }
}

class Program
{
    static void Main()
    {
        var zoo = new Zoo(5);
        zoo.Add(new Dog("Рекс"));
        zoo.Add(new Cat("Снежок"));
        zoo.Add(new Elephant("Балу"));
        zoo.Add(new Dog("Шарик"));
        zoo.Add(new Cat("Мурка"));

        zoo.MakeAllSounds();

        zoo.FeedAll();

        zoo.RestAll();
    }
}

