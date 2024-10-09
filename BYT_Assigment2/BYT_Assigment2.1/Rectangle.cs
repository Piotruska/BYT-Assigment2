namespace BYT_Assigment2;

public class Rectangle(float length, float width) : IShape
{
    private readonly float _width = width;
    private readonly float _length = length;

    public double CalculatedArea()
    {
        return length * width;
    }

    public double CalculatedVolume()
    {
        return 0;
    }
}