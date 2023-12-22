using StatePattern.Models;

namespace StatePattern.StatePattern.State;

public class MoveState : State
{
    private readonly Robot robot;

    public MoveState(Robot robot) : base(robot)
    {
        this.robot = robot;
    }

    public override string OnMoveStay()
    {
        var message = robot.Stay();
        robot.setState(new StayState(robot));

        return message;
    }

    public override string OnOnOff()
    {
        var message = robot.TurnOff();
        robot.setState(new OffState(robot));

        return message;
    }
}