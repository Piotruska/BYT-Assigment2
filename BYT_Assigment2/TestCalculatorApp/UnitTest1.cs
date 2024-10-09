using ConsoleApp1;

namespace TestProject1;

public class Tests
{
    private readonly Calculator calculator = new Calculator();

    [Test]
    public void TestAddition()
    {
        Assert.That(calculator.Calculate(1,2,'+'), Is.EqualTo(3));
    }
    [Test]
    public void TestSubtraction()
    {
        Assert.That(calculator.Calculate(1,2,'-'), Is.EqualTo(-1));
    }
    [Test]
    public void TestMultiplication()
    {
        Assert.That(calculator.Calculate(5,2,'*'), Is.EqualTo(10));
    }
    [Test]
    public void TestDivision()
    {
        Assert.That(calculator.Calculate(2, 6, '/'), Is.EqualTo(0.334).Within(0.001));
    }
    [Test]
    public void TestDivisionByZeroExeption()
    {
        try
        {
            calculator.Calculate(2, 0, '/');
        }
        catch (Exception e)
        {
            if (e.Message.Equals("Cannot divide by 0"))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
    [Test]
    public void TestWrongOperatorExeption()
    {
        try
        {
            calculator.Calculate(2, 3, 'a');
        }
        catch (Exception e)
        {
            if (e.Message.Equals("Incorrect operation : a"))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}