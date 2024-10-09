namespace BYT_Assigment2;

public class Cube(double side) : IShape
{

    public double CalculatedArea()
    {
        return 6 * Math.Pow(side, 2);
    }

    public double CalculatedVolume()
    {
        return Math.Pow(side, 3);
    }
}