using ObservePattern.Models;

namespace ObservePattern.Interfaces;

public interface IObserver
{
    void Update(Email customer);
}