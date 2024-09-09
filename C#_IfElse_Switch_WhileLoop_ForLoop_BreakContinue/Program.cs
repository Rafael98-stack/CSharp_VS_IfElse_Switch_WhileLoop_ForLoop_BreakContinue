// See https://aka.ms/new-console-template for more information

/////////////////////////////////////////////////////////////////////////////////////////////////

/* IF ELSE */

// Conditions and If Statements

/* 
Less than: a < b

Less than or equal to: a <= b

Greater than: a > b

Greater than or equal to: a >= b

Equal to a == b

Not Equal to: a != b
 */

// Can use these conditions to perform different actions for different decisions

int myInt = 10;
int myInt2 = 20;
int myInt3 = 20;

string firstName = "Marco";
string lastName = "Neri";

if (myInt == 10) {

    Console.WriteLine($"My int is equal to {myInt}");

};

if (myInt < myInt2) {

    Console.WriteLine($"My int: {myInt} is less than {myInt2}");

};

/* IF ELSE / ELSE IF */

if (myInt == myInt2) { 
    Console.WriteLine("My int has the same value of int2");
} else {
    Console.WriteLine("They are with different value");
};

if (myInt >= myInt3)
{
    Console.WriteLine($"My Firstname is {firstName}");
} else if (myInt3 != 0)
{
    Console.WriteLine($"My Lastname is {lastName}");
}

/* TERNARY OPERATOR */

string result = (myInt == 10) ? $"My int is equal to {myInt}" : $"My int is not equal to {myInt}" ;

Console.WriteLine(result);

/* SWITCH STATEMENT */

Console.WriteLine("Enter your number 0 to 9");

int myNumber = Convert.ToInt32(Console.ReadLine());

switch (myNumber)
{
    case 0:
        Console.WriteLine($"Your Number: {myNumber}");
        break;
    case 1:
        Console.WriteLine($"Your Number: {myNumber}");
        break;
    case 2:
        Console.WriteLine($"Your Number: {myNumber}");
        break;
    case 3:
        Console.WriteLine($"Your Number: {myNumber}");
        break;
    case 4:
        Console.WriteLine($"Your Number: {myNumber}");
        break;
    case 5:
        Console.WriteLine($"Your Number: {myNumber}");
        break;
    case 6:
        Console.WriteLine($"Your Number: {myNumber}");
        break;
    case 7:
        Console.WriteLine($"Your Number: {myNumber}");
        break;
    case 8:
        Console.WriteLine($"Your Number: {myNumber}");
        break;
          case 9:
        Console.WriteLine($"Your Number: {myNumber}");
        break;
}

/* WHILE LOOP */

int myInt0 = 0;

while (myInt0 <= 10)
{
    Console.WriteLine(myInt0);
    myInt0++;
}

// DO WHILE

myInt0 = 0;

do
{
    Console.WriteLine(myInt0);
    myInt0++;
}
while (myInt0 <= 10);

/* FOR LOOP / FOREACH LOOP */

/* 
 
for (statement 1; statement 2; statement 3) 
{
  // code block to be executed
} 

*/

int i = 0;

for ( i = 0; i <= 10; i++) 
{ 
    Console.WriteLine(i + " Im a i");
}

// NESTED FOR LOOP / CONTINUE & BREAK

i = 0;

for ( i = 0;i <= 10; i++)
{
    for (; i == 5; i++)
    {
        Console.WriteLine("Number 5 has been jumped");
        continue;
    }
    if (i == 9)
    {
        Console.WriteLine("I break here");
        break;
    }
    Console.WriteLine(i);
}