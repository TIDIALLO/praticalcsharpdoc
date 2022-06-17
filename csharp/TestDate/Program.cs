using static System.Console;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using testLogger;

public class Program
{
    public static void Main(){
        BadTiming();
        WriteLine("\n\n");

        GoodTiming();

        WriteLine("===========================================");
        WriteLine("Test Logger Class");

        var logger = new Logger();
        WriteLine(logger.Log("Hello, this is Tidiane Diallo"));
        ReadLine();
    }
    public static void DoSomething1(DateTimeOffset dt)
    {
        // do something
        WriteLine(dt.ToString("o"));
    }
    public static void DoSomething2(DateTimeOffset dt)
    {
        // do something else
        WriteLine(dt.ToString("o"));
    }
    public static void BadTiming()
    {
        WriteLine("Testing Bad Timing");

        Write("First Stamp: ");
        DoSomething1(DateTimeOffset.Now);
        
        Write("Second Stamp: ");
        DoSomething2(DateTimeOffset.Now);
    }

    public static void GoodTiming()
    {
        WriteLine("Testing Good Timing");

        var now = DateTimeOffset.Now;
        
        Write("First Stamp: ");
        DoSomething1(now);

        Write("Second Stamp: ");
        DoSomething2(now);
    }
    
}
