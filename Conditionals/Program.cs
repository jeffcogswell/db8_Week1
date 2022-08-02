//Console.WriteLine("What is your name?");
//string entry = Console.ReadLine();
//Console.WriteLine($"Great to meet you, {entry}");

Console.WriteLine("Please enter a number:");

string entry = Console.ReadLine();
int n = int.Parse(entry);

if (n > 50)
{
	Console.WriteLine("Yes, n is greater than 50.");
	Console.WriteLine($"n is {n}");
}
else
{
	Console.WriteLine("No, n is not greater than 50.");
	Console.WriteLine($"n is {n}");
}

// Let's see if the number is between 3 and 10 exclusive

if (  (n>3)  &&  (n<10)   )
{
	Console.WriteLine("Yes, n is between 3 and 10 exclusive");
}
else
{
	Console.WriteLine("No, n is not between 3 and 10 exclusive.");
}

// Let's see if the number is between 3 and 10 inclusive

if (   (n >= 3) && (n <= 10)   )
{
	Console.WriteLine("Yes, n is between 3 and 10 inclusive");
}
else
{
	Console.WriteLine("No, n is not between 3 and 10 inclusive.");
}


//if (false)
//{
//	Console.WriteLine("It evaluated to true");
//}
//else
//{
//	Console.WriteLine("It evaluated to false");
//}
