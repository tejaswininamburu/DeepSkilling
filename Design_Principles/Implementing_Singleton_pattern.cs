using System;

class Logger
{
    // Static instance
    private static Logger instance;

    // Private constructor
    private Logger()
    {
        Console.WriteLine("Logger Instance Created");
    }

    // Method to return the single instance
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }
        return instance;
    }

    // Logging method
    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get first instance
        Logger logger1 = Logger.GetInstance();
        logger1.Log("Application Started");

        // Get second instance
        Logger logger2 = Logger.GetInstance();
        logger2.Log("Processing Data");

        // Check whether both references point to the same object
        if (logger1 == logger2)
        {
            Console.WriteLine("Only one Logger instance is created.");
        }
        else
        {
            Console.WriteLine("Multiple Logger instances are created.");
        }
    }
}