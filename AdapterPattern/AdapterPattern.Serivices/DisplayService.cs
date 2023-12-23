using AdapterPattern.AdapterPattern.Interfaces;

namespace AdapterPattern.AdapterPattern.Serivices;

public class DisplayService : IDisplayService
{
    public void DisplayError(string json)
    {
        Console.WriteLine(json);
    }
}