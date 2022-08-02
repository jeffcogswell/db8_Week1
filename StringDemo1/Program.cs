string name = "Fred";
Console.WriteLine(name);
string uppername = name.ToUpper();  // Strings are "immutable"
Console.WriteLine(uppername);
Console.WriteLine(name);

Console.WriteLine(name[0]);
Console.WriteLine(name[1]);

Console.WriteLine(name.ToLower());

// Floating Point Types

double pi = 3.1415926;
Console.WriteLine(pi);
double pi2 = pi * 2;
Console.WriteLine(pi2);

Console.WriteLine(Math.Sqrt(pi));

double q = Math.Sqrt(25);
Console.WriteLine(q);

//float n = 3.1415926f; We rarely use float these days. Put an F or f after it to initialize it.

//float n = 10;
//n = n / 3;
//Console.WriteLine(n);
//Console.WriteLine(n + n + n);

// When we are working with money, we don't use float or double.

decimal amount = 99.95m;
Console.WriteLine(amount);
amount = amount * 2;
Console.WriteLine(amount);

bool passed = true;
Console.WriteLine(passed);
passed = false;
Console.WriteLine(passed);
passed = !passed;   // passed was false; the "not" operator flips it to true
Console.WriteLine(passed);


