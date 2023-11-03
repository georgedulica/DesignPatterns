using FactoryPattern.Interface;

namespace FactoryPattern.Pizzas;

public class MargheritaPizza : IPizza
{
    public void GetPizza()
    {
        Console.WriteLine("Margherita Pizza is done");
    }
}