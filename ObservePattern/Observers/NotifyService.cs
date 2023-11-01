using ObservePattern.Interfaces;
using ObservePattern.Models;
using ObservePattern.Observables;

namespace ObservePattern.Observers;

public class NotifyService : IObserver
{
    public void Update(Email customer)
    {
        Console.WriteLine($"{customer.EmailAddress}-{customer.Message}");
    }
}