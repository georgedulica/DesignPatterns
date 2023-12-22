using StatePattern.StatePattern.State;

namespace StatePattern.Models;

public class Robot
{
    internal State state;

    public Robot()
    {
        this.state = new OffState(this);    
    }

    public void setState(State state)
    {
        this.state = state;
    }

    public string TurnOn()
    {
        var message = "The robot is on";
        return message;
    }

    public string TurnOff()
    {
        var message = "The robot is off";
        return message;
    }    
    
    public string Move()
    {
        var message = "The robot is moving now";
        return message;
    }    
    
    public string Stay()
    {
        var message = "The robot is staying now";
        return message;
    }
}
