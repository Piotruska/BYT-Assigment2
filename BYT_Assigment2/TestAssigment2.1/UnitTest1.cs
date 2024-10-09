namespace TestProject1;
using BYT_Assigment2;
using NUnit.Framework;

public class Tests
{
    // [SetUp]
    // public void Setup()
    // {
    // }

    private readonly IShape sphere = new Sphere(5);

    [Test]
    public void TestSphereCalculateArea()
    {
        Assert.That(sphere.CalculatedArea(), Is.EqualTo(314.159).Within(0.001));
        
    }

    [Test]
    public void TestSphereCalculateVolume()
    {
        Assert.That(sphere.CalculatedVolume(), Is.EqualTo(523.598).Within(0.001));
    }
}
