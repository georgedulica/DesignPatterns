using FactoryPattern.Interface;
using FactoryPattern.Pizzas;

namespace FactoryPattern.ContosoPizzas;

public class ContosoMargheritaPizza : ContosoPizza
{
    protected override IPizza PreparePizza()
    {
        return new MargheritaPizza();
    }
}