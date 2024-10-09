namespace ConsoleApp1;

public class Calculator
{
    public Calculator()
    {
    }

    public float Calculate(float a,float b,char operation)
    {
        switch (operation)
        {
            case '+':
                return a + b;
                break;
            case '-':
                return a - b;
                break;
            
            case '*':
                return a * b;
                break;
            
            case '/':
                if (b == 0)
                {
                    throw new Exception("Cannot divide by 0");
                }
                else
                {
                    return a / b;
                }

                break;
            default:
                throw new Exception("Incorrect operation : " + operation);
        }
        
    }
}