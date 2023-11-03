using FactoryPattern.Interface;

namespace FactoryPattern.Pizzas;

public class GreekPizza : IPizza
{
    public void GetPizza()
    {
        Console.WriteLine("Greek Pizza is done");
    }
}