using System;

// Step 1: Document Interface
interface IDocument
{
    void Open();
}

// Step 2: Concrete Document Classes
class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Word Document Created.");
    }
}

class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("PDF Document Created.");
    }
}

class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Excel Document Created.");
    }
}

// Step 3: Abstract Factory
abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

// Step 4: Concrete Factories
class WordFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

class PdfFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}

class ExcelFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}

// Step 5: Test Class
class Program
{
    static void Main(string[] args)
    {
        DocumentFactory factory;

        factory = new WordFactory();
        IDocument doc1 = factory.CreateDocument();
        doc1.Open();

        factory = new PdfFactory();
        IDocument doc2 = factory.CreateDocument();
        doc2.Open();

        factory = new ExcelFactory();
        IDocument doc3 = factory.CreateDocument();
        doc3.Open();
    }
}