using SingletonPattern;

public class Program
{
    public static void Main()
    {
        var firstThread = new Thread(() =>
        {
            var instance = PlayService.Instance();
        });        
        var secondThread = new Thread(() =>
        {
            var instance = PlayService.Instance();
        });

        firstThread.Start();
        secondThread.Start();
        firstThread.Join();
        secondThread.Join();
    }
}