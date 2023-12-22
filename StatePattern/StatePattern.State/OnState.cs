using StatePattern.Models;

namespace StatePattern.StatePattern.State;

public class OnState : State
{
    private readonly Robot robot;

    public OnState(Robot robot) : base(robot)
    {
        this.robot = robot;   
    }

    public override string OnMoveStay()
    {
        var message = robot.Move();
        robot.setState(new MoveState(robot));

        return message;
    }

    public override string OnOnOff()
    {
        var message = robot.TurnOff();
        robot.setState(new OffState(robot));

        return message;
    }
}