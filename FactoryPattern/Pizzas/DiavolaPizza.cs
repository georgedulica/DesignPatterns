using FactoryPattern.Interface;

namespace FactoryPattern.Pizzas;

public class DiavolaPizza : IPizza
{
    public void GetPizza()
    {
        Console.WriteLine("Diavola Pizza is done");
    }
}