using StatePattern.Models;
using StatePattern.StatePattern.State;

public class Program
{
    static void Main()
    {
        var robot = new Robot();                            // state off
        Console.WriteLine(robot.state.OnOnOff());           // state on
        Console.WriteLine(robot.state.OnMoveStay());        // state move
        Console.WriteLine(robot.state.OnOnOff());           // state off
        Console.WriteLine(robot.state.OnMoveStay());        // state off
        Console.WriteLine(robot.state.OnOnOff());           // state on
        Console.WriteLine(robot.state.OnMoveStay());        // state move
        Console.WriteLine(robot.state.OnMoveStay());        // state stay
        Console.WriteLine(robot.state.OnOnOff());           // state off
    }
}