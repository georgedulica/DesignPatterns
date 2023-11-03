using FactoryPattern.Interface;
using FactoryPattern.Pizzas;

namespace FactoryPattern.ContosoPizzas;

internal class ContosoGreekPizza : ContosoPizza
{
    protected override IPizza PreparePizza()
    {
        return new GreekPizza();
    }
}