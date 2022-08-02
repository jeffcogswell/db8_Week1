// For loop

for (int index = 0; index < 10; index++)
{
	Console.WriteLine(index);
}

Console.WriteLine();
// The index variable lives only during the loop and is then forgotten.
for (int index = 0; index < 10; index+=2)
{
	Console.WriteLine(index);
}

Console.WriteLine();

for (int index = 21; index >= -9; index = index - 3)
{
	Console.WriteLine(index);
}

Console.WriteLine("All done! On to while loops!");
Console.WriteLine();

// While loop

int w = 1;
while (w < 5)
{
	Console.WriteLine("Inside while loop");
	Console.WriteLine(w);
	w++;
}

// Example of a break statement inside a while(true)
Console.WriteLine();
int w2 = 10;
while (w2 >= 0)
{
	if (w2 == 4)
	{
		Console.WriteLine("Oops, found corrupted data");
		break; // This exits the loop immediately. (Break does not exit out of if statements.)
	}
	Console.WriteLine(w2);
	w2--;
}

Console.WriteLine("Finished with while loops. On to do-while loops");
Console.WriteLine();

// With while loops, the condition is tested before each iteration.
// With do-while loops, the condition is tested after each iteration.

int w3 = 0;
do
{
	Console.WriteLine(w3);
	w3++;
}
while (w3 < 10);

Console.WriteLine("All done with while loops! Now a nested for loop.");

for (int x = 1; x <= 5; x++)
{
	Console.WriteLine($"Starting outer loop. x is {x}");
	for (int y = 1; y <= 3; y++)
	{
		Console.WriteLine($"x:{x}  y:{y}");
	}
	Console.WriteLine();
}

Console.WriteLine("How about a clock!");

for (int hour = 0; hour < 24; hour ++)
{
	Console.WriteLine($"The hour is {hour}");
	for (int minute = 0; minute < 60; minute++)
	{
		Console.WriteLine($"  {hour}:{minute}");
	}
}
