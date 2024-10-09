namespace BYT_Assigment2;

public class Sphere(double radius) : IShape
{

    public double CalculatedArea()
    {
        return 4 * Math.PI * Math.Pow(radius, 2);
    }

    public double CalculatedVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
}