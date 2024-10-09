

// Create a Sphere with radius 5

using BYT_Assigment2;

IShape sphere = new Sphere(5);
Console.WriteLine("Sphere:");
Console.WriteLine($"Area: {sphere.CalculatedArea():F3}");
Console.WriteLine($"Volume: {sphere.CalculatedVolume():F3}");
Console.WriteLine();

// Create a Cylinder with radius 3 and height 7
IShape cylinder = new Cylinder(3, 7);
Console.WriteLine("Cylinder:");
Console.WriteLine($"Area: {cylinder.CalculatedArea():F3}");
Console.WriteLine($"Volume: {cylinder.CalculatedVolume():F3}");
Console.WriteLine();

// Create a Rectangle with length 4 and width 8
IShape rectangle = new Rectangle(4, 8);
Console.WriteLine("Rectangle:");
Console.WriteLine($"Area: {rectangle.CalculatedArea():F3}");
// Rectangle is a 2D shape, so volume is 0
Console.WriteLine($"Volume: {rectangle.CalculatedVolume():F3}");
Console.WriteLine();

// Create a Cube with side 4
IShape cube = new Cube(4);
Console.WriteLine("Cube:");
Console.WriteLine($"Area: {cube.CalculatedArea():F3}");
Console.WriteLine($"Volume: {cube.CalculatedVolume():F3}");

