using static System.Console;
namespace testLogger;
public class Logger
{
    public string Log(string message){
        return $"{DateTimeOffset.Now}: {message}";
    }
}