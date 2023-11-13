namespace PrototypePattern;

public class Car : Vehicle
{
    private int _speed;
    private string _color;
    private string _model;

    public Car(int speed, string color, string model) : base(speed, color, model)
    {
        _speed = speed;
        _color = color;
        _model = model;
    }

    public override Vehicle Clone()
    {
        return new Car(_speed, _color, _model);
    }
}