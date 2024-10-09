using ConsoleApp1;

Calculator calculator = new Calculator();



var x =calculator.Calculate(1,2,'+');
Console.WriteLine(x);
x = calculator.Calculate(2,4,'-');
Console.WriteLine(x);
x = calculator.Calculate(5,6,'*');
Console.WriteLine(x);
x = calculator.Calculate(2, 6, '/');
Console.WriteLine(x);
//x = calculator.Calculate(2, 0, '/');
//Console.WriteLine(x);
