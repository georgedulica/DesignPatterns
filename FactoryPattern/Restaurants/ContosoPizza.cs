using FactoryPattern.Interface;

public abstract class ContosoPizza
{
    public IPizza OrderPizza()
    {
        var pizza = PreparePizza();
        return pizza;
    }

    protected abstract IPizza PreparePizza();
}