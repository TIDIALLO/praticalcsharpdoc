using static System.Console;

namespace apiMailID.Services;
public class EmailSender{
    public void SendEmail(string username)
    {
        WriteLine($"Email sent to {username}!");
    }
}