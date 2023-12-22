using StatePattern.Models;

namespace StatePattern.StatePattern.State;

public abstract class State
{
    private readonly Robot robot;

    public State(Robot robot)
    {
        this.robot = robot;
    }

    public abstract string OnOnOff();

    public abstract string OnMoveStay();
}