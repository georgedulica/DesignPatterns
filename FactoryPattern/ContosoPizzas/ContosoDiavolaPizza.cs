using FactoryPattern.Interface;
using FactoryPattern.Pizzas;

namespace FactoryPattern.ContosoPizzas;

public class ContosoDiavolaPizza : ContosoPizza
{
    protected override IPizza PreparePizza()
    {
        return new DiavolaPizza();
    }
}