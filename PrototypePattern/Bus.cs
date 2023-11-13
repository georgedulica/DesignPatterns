namespace PrototypePattern;

public class Bus : Vehicle
{
    private int _speed;
    private string _color;
    private string _model;

    public Bus(int speed, string color, string model) : base(speed, color, model)
    {
        _speed = speed;
        _color = color;
        _model = model;
    }

    public override Vehicle Clone()
    {
        return new Bus(_speed, _color, _model);
    }
}