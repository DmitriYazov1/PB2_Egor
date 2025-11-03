


class Car
{

   
    public string Brand { get; }
    public int Speed { get; private set; }

    public Car(string name, int speed)
    {
         Speed = speed;
         Brand = name;
    }
    public void Accel()
        {
            Speed += 10;
        }
}


class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public Book(string title, string author, int pages)
    {
         Title = title;
         Author = author;
         Pages = pages;
    }

    public void Read(int pages_read)
    {
        if (pages_read > Pages || pages_read < 0)
        {
            Console.WriteLine($"Error");
        }
        else
        {
            Console.WriteLine($"Вы прочитали {pages_read} страниц из {Pages}");
        }
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void PrintAllBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine(book.Title);
        }
    }
}


