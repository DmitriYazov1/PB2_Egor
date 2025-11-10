class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageCount { get; set; }

    public Book()
    {
        Title = "Неизвестно";
        Author = "Неизвестно";
        PageCount = 0;
    }

    public Book(string title)
    {
        Title = title;
        Author = "Неизвестно";
        PageCount = 0;
    }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        PageCount = 0;
    }

    public Book(string title, string author, int pageCount)
    {
        Title = title;
        Author = author;
        PageCount = pageCount;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title}, Автор: {Author}, Страниц: {PageCount}");
    }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Speed { get; set; }

    public Car() : this("Неизвестно", "Неизвестно", 0)
    {
    }

    public Car(string brand) : this(brand, "Неизвестно", 0)
    {
    }

    public Car(string brand, string model, int speed)
    {
        this.Brand = brand;
        this.Model = model;
        this.Speed = speed;
    }
}

class Player
{
    public string Name;
    public int Level;
    public void PrintInfo()
    {
        Console.WriteLine($"{Name}, {Level}");
    }
    
}



class User
{
    private string password;
    public string Name;

    public string Password
    {
        get { return password; }

        set
        {
            if (value != null)
            {
                password = value;
                Console.WriteLine("Пароль обновлен");
            }
        }
    }
    
    public bool CheckPassword(string input)
    {
        return password == input;
    }
}

class Point
{
    public int X;
    public int Y;

    public void Move(int dx, int dy)
    {
        X += dx;
        Y += dy;
    }
}

class Program
{
    static void Main()
    {
        //1 
        var b1 = new Book();
        var b2 = new Book("1984");
        var b3 = new Book("Гроза", "Островский");
        var b4 = new Book("Гарри Поттер", "Дж. Роулинг", 500);

        b1.PrintInfo();
        b2.PrintInfo();
        b3.PrintInfo();
        b4.PrintInfo();

        //3

        Player p1 = new Player();
        p1.Name = "Алекс";

        Player p2 = new Player();
        p2.Name = "Алекс";

        Console.WriteLine($"{p1 == p2}");

        Console.WriteLine($"{Equals(p1, p2)}");

        //4
        var user = new User();
        user.Name = "admin";
        user.Password = "12345";
        Console.WriteLine(user.CheckPassword("12345"));
        user.Password = "";

        //5
        Point p1_point = new Point();
        p1_point.X = 10;
        p1_point.Y = 20;

        Point p2_point = p1_point;

        Console.WriteLine($"До изменения: p1_point = ({p1_point.X}, {p1_point.Y}), p2_point = ({p2_point.X}, {p2_point.Y})");

        p2_point.Move(5, 5);

        Console.WriteLine($"После изменения p2_point: p1_point = ({p1_point.X}, {p1_point.Y}), p2_point = ({p2_point.X}, {p2_point.Y})");


    }
}