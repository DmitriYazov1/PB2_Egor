using System;

//1
interface IPlayble
{
    void Play();
}

class Guitar : IPlayble
{
    public void Play()
    {
        Console.WriteLine("Гитара играет аккорды");
    }
}

class Piano : IPlayble
{
    public void Play()
    {
        Console.WriteLine("Пианино играет мелодию");
    }
}

class Drum : IPlayble
{
    public void Play()
    {
        Console.WriteLine("Барабан отбивает ритм");
    }
}

//2
interface IReadble
{
    void Read(string filename);
}

interface IWriteble
{
    void Write(string filename, string content);
}

interface ISaveble
{
    void Save();
}

class Textdocument : IReadble, IWriteble, ISaveble
{
    private string content;
    public void Read(string filename)
    {
        Console.WriteLine($"Чтение из файла {filename}");
        content = "текст из файла";
    }

    public void Write(string filename, string content)
    {
        Console.WriteLine($"Запись в файл {filename}: {content}");
        this.content = content;
    }

    public void Save()
    {
        Console.WriteLine($"Файл сохранён. Содержимое: {content}");
    }
}

//3
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

class Program
{
    static void Main()
    {
        //1
        IPlayble[] instruments =
        {
            new Guitar(),
            new Piano(),
            new Drum()
        };
        foreach (var instrument in instruments)
        {
            instrument.Play();
        }

        Console.WriteLine();

        //2
        Textdocument textdocument = new Textdocument();
        textdocument.Read("data.txt");
        textdocument.Write("data.txt", "Привет, мир!");
        textdocument.Save();

        Console.WriteLine();

        //3
        IDocumentExporter[] exporters =
        {
            new TxtExporter(),
            new PdfExporter()
        };

        foreach (var exporter in exporters)
        {
            exporter.ShowInfo("Hello World!");
            exporter.Export("Hello World!");
        }
    }
}