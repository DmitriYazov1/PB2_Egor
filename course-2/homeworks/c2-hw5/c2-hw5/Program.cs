class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public double Rating { get; set; }

    public Movie() : this("Без названия", "Неизвестен", 0)
    {
    }

    public Movie(string title) : this(title, "Неизвестен", 0)
    {
    }

    public Movie(string title, string genre, double rating)
    {
        this.Title = title;
        this.Genre = genre;
        this.Rating = rating;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Название: {Title}, жанр: {Genre}, рейтинг: {Rating}");
    }
}

class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name}, возраст {Age}");
    }
}

class Program
{
    static void Main()
    {
        var m1 = new Movie();
        var m2 = new Movie("Матрица");
        var m3 = new Movie("Начало", "Фантастика", 9);

        m1.PrintInfo();
        m2.PrintInfo();
        m3.PrintInfo();

        var cat1 = new Cat("Барсик", 2);
        var cat2 = cat1;
        cat2.Age = 5;

        cat1.PrintInfo();
        cat2.PrintInfo();

        var cat3 = new Cat(cat1.Name, cat1.Age);
        cat3.Age = 10;

        cat1.PrintInfo();
        cat2.PrintInfo();
        cat3.PrintInfo();
    }
}