using System;

class Circle : Shape
{
    private float _pi;
    private float _radius;


    public Circle(string color, int side) : base(color)
    {
        _pi = 3.14159f;
        _radius = side;
    }


    public override double GetArea()
    {
        return _pi * (_radius*2) ;
    }
}