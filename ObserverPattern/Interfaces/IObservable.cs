using ObserverPattern.Models;

namespace ObserverPattern.Interfaces;

public interface IObservable
{
    void Subscribe(Email email);

    void Unsubscribe(Email email);

    void Notify();
}