using PrototypePattern;

class Program
{
    public static void Main()
    {
        var audi = new Car(40, "red", "audi");
        var bmw = new Car(45, "blue", "bmw");
        var ctp35 = new Bus(23, "purple", "ctp35");
        var ctp45 = new Bus(23, "purple", "ctp45");

        var clonedAudi = audi.Clone();
        var clonedBmw = bmw.Clone();
        var clonedCtp35 = ctp35.Clone();
        var clonedCtp45 = ctp45.Clone();

        ctp35.Accelerate();
        ctp45.Accelerate();
        ctp45.Accelerate();

        var vehicles = new List<Vehicle>
        {
            audi,
            bmw,
            ctp35,
            ctp45,
            clonedAudi,
            clonedBmw,
            clonedCtp35,
            clonedCtp45
        };

        foreach(var vehicle in vehicles)
        {
            Console.WriteLine("The speed for " + vehicle.Model + " with color " + vehicle.Color + " is " + vehicle.Speed);
        }
    }
}