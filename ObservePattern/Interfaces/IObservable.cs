using ObservePattern.Models;

namespace ObservePattern.Interfaces;

public interface IObservable
{
    void Subscribe(Email email);

    void Unsubscribe(Email email);

    void Notify();
}