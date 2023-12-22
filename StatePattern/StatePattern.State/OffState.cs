using StatePattern.Models;

namespace StatePattern.StatePattern.State;

public class OffState : State
{
    private readonly Robot robot;

    public OffState(Robot robot) : base(robot)
    {
        this.robot = robot;
    }

    public override string OnMoveStay()
    {
        var message = "You can't move the robot, please firstly turn it on";

        return message;
    }

    public override string OnOnOff()
    {
        var message = robot.TurnOn();
        robot.setState(new OnState(robot));

        return message;
    }
}