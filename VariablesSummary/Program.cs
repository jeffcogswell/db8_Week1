﻿// Integers

int x = 10;
x = x * 2;
x++;
Console.WriteLine(x); // Expect to see 21

// Strings

string product = "Monitor";
product = product.ToUpper();
Console.WriteLine(product); // Expect to see MONITOR

// Double

double first = 2.5;
double pi = Math.PI;
Console.WriteLine(first);
Console.WriteLine(pi);
double mult = first * pi;
Console.WriteLine(mult);
double mult2 = first * Math.PI;
Console.WriteLine(mult2);

// Decimal (Money)

decimal charge = 10.25m; // m for "money"
decimal perc = charge / 3;
Console.WriteLine(perc);

// Boolean

bool finished = false;
Console.WriteLine(finished); // Expect to see False
bool another = !finished;
Console.WriteLine(another);  // Expect to see True

Console.WriteLine();
Console.WriteLine("Expressions that are true or false");
int q = 20;
bool test1 = (q > 10);  // Not a question: Is q greater than 10? Instead a sentence: "q is greater than 10." Is that True or false?
Console.WriteLine(test1); // Expect to see True

// Let's just print a couple our directly

Console.WriteLine(q > 30); // Statement: "q is greater than 20" Expect to see False
Console.WriteLine(q == 20); // Statement: "q is equal to 20" Expect to see True
Console.WriteLine(q != 20); // Statement: "q is not equal to 20" Expect to see False <-- THINK THIS THROUGH CAREFULLY
Console.WriteLine(  !(q != 20)   );

// Let's add in "and" "or"
int j = 10;
int k = 11;

Console.WriteLine(  (j == 10) && (k == 11)  ); // Statement is "j equals 10 AND k equals 11" Expect to see true
Console.WriteLine(  (j == 10) && (k == 12)  ); // Expect to see False
Console.WriteLine(  (j == 10) || (k == 12)  ); // Expect to see True

