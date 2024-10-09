namespace BYT_Assigment2;

public class Cylinder(double radious, double height) : IShape
{

    public double CalculatedArea()
    {
        return 2 * Math.PI * radious * (radious * height);
    }

    public double CalculatedVolume()
    {
        return Math.PI * Math.Pow(radious, 2) * height;

    }
}