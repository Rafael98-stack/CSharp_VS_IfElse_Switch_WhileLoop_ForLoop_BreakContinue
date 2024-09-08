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