using ObserverPattern.Interfaces;
using ObserverPattern.Models;

namespace ObserverPattern.Observers;

public class NotifyService : IObserver
{
    public void Update(Email customer)
    {
        Console.WriteLine($"{customer.EmailAddress}-{customer.Message}");
    }
}