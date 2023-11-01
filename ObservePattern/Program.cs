using ObservePattern.Models;
using ObservePattern.Observables;
using ObservePattern.Observers;

public class Program
{
    public static void Main()
    {
        var customer1 = new Email
        {
            EmailAddress = "customer1@xyz.com",
            Message = "Your product is back in stock."
        };        
        var customer2 = new Email
        {
            EmailAddress = "customer2@xyz.com",
            Message = "Your product is out of stock."
        };

        var customers = new List<Email>
        {
            customer1,
            customer2
        };

        var notificationService = new NotifyService(); 
        var store = new Store(customers, notificationService);
        store.Notify();
    }
}