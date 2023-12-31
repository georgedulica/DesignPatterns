﻿using ObserverPattern.Interfaces;
using ObserverPattern.Models;
using ObserverPattern.Observers;

namespace ObserverPattern.Observables;

public class Store : IObservable
{
    private readonly IList<Email> customers;
    private readonly IObserver notifyService;
    
    public Store(IList<Email> customers, IObserver notifyService)
    {
        this.customers = customers;
        this.notifyService = notifyService;
    }

    public void Subscribe(Email email)
    {
        customers.Add(email);
    }

    public void Unsubscribe(Email email)
    {
        customers.Remove(email);
    }

    public void Notify()
    {
        foreach (var customer in customers)
        {
            notifyService.Update(customer);
        }
    }
}
