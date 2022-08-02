// Ask use for length and width

const double height = 8;

Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

Console.WriteLine("Enter Length:");
string entry = Console.ReadLine();
double length = double.Parse(entry);

Console.WriteLine("Enter Width:");
entry = Console.ReadLine();
double width = double.Parse(entry);

// Calculate area and perimeter

double area = length * width;
Console.WriteLine($"Area: {area}");

double perimeter = (2 * length) + (2 * width);
Console.WriteLine($"Perimeter: {perimeter}");

// Determine small, medium, large

if (area <= 250)
{
	Console.WriteLine("This is a small room.");
}
else if (area < 650)
{
	Console.WriteLine("This is a medium room.");
}
else
{
	Console.WriteLine("This is a large room.");
}

// Extended Challenge: Volume of the room

Console.WriteLine($"Volume: {area * height}");

// Extended Challenge: Surface Area of the Room
Console.WriteLine($"Surface Area: {area * 2 + (length * height * 2) + (width * height * 2)}");

