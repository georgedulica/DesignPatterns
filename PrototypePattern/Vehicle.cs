namespace PrototypePattern;

public abstract class Vehicle
{
    private int _speed;
    private string _color;
    private string _model;

    public Vehicle()
    {
        _speed = 0;
        _color = "Undefined";
    }

    public Vehicle(int speed, string color, string model)
    {
        _speed = speed;
        _color = color;
        _model = model;
    }

    public string Color { get => _color; }

    public int Speed { get => _speed; }

    public string Model { get => _model; }

    public int Accelerate()
    {
        _speed += 1;
        return _speed;
    }

    public int Break()
    {
        _speed -= 1;
        return _speed;
    }

    public abstract Vehicle Clone();
}