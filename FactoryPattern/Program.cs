using FactoryPattern.ContosoPizzas;

class Program
{
    public static void Main()
    {
        var contosoDiavolaPizza = new ContosoDiavolaPizza();
        var contosoGreekPizza = new ContosoGreekPizza();
        var contosoMargheritaPizza = new ContosoMargheritaPizza();
        
        var diavolaPizza = contosoDiavolaPizza.OrderPizza();
        var greekPizza = contosoGreekPizza.OrderPizza();
        var margheritaPizza = contosoMargheritaPizza.OrderPizza();

        diavolaPizza.GetPizza();
        greekPizza.GetPizza();
        margheritaPizza.GetPizza();
    }
}