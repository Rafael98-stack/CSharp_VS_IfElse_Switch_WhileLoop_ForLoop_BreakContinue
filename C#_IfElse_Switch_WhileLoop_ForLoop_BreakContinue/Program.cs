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

// FOREACH LOOP / ARRAYS

// Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
// To declare an array, define the variable type with square brackets

string[] names = { "Marco", "Giulio", "Luca" };

int[] numbersRandom = { 1, 78, 5, 10 };

foreach (string a in names)
{
    Console.WriteLine($"Hello {a}");
}

foreach (int n in numbersRandom)
{
    Console.WriteLine($"My numbers {n}");
}

Console.WriteLine(numbersRandom.Length); // Array Length, To find out how many elements an array has

numbersRandom[2] = 20; // Change an Array Element, to change the value of a specific element, refer to the index number

Console.WriteLine(numbersRandom[2]); // Access the Elements of an Array, access an array element by referring to the index number

// Other Ways to Create an Array

// Create an array of four elements, and add values later
string[] cars = new string[4];

// Create an array of four elements and add values right away 
string[] shoes = new string[3] { "adidas", "nike", "puma" };

// Create an array of four elements without specifying the size 
string[] carsType = new string[] { "Berlina", "SUV"};

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] friends = { "Luca", "Mario", "Francesco", "Iacopo" };

// Sort an Array

// .Sort(x) sorts an array alphabetically or in an ascending order

Array.Sort(friends);
foreach (string friend in friends)
{
    Console.WriteLine(friend);
}

Array.Sort(numbersRandom);
foreach (int n in numbersRandom)
{
    Console.WriteLine(n);
}

// Using Max() , Min() , Sum()

Console.WriteLine(numbersRandom.Max()); // Returns the largest value
Console.WriteLine(numbersRandom.Min()); // Returns the smallest value
Console.WriteLine(numbersRandom.Sum()); // Returns the sum of elements 

/* MULTIDIMENSIONAL ARRAYS */
// To access an element of a two-dimensional array, you must specify two indexes: one for the array, and one for the element inside that array

int[,] multiDimNum = { {1,2,3 }, {4,5,6 } };

Console.WriteLine("I'm the number 4 of the second array - " + multiDimNum[1,0]);
Console.WriteLine("I'm the number 3 of the first array - " + multiDimNum[0, 2]);

// The value of an element can also be changed

multiDimNum[0,2] = 10;
Console.WriteLine("I've changed - " + multiDimNum[0, 2]);

// Loop through the elements of a two-dimensional array with a foreach loop is also available

foreach (int n in multiDimNum)
{
    Console.WriteLine($"{n}");
}
Console.WriteLine();

// Loop through the elements of a two-dimensional array with a for loop is also available

for (int n = 0; n < multiDimNum.GetLength(0); n++) // have to use GetLength() instead of Length to specify how many times the loop should run
{
    for (int n2 = 0; n2 < multiDimNum.GetLength(1); n2++)
    {
        Console.WriteLine(multiDimNum[n,n2]);
    }
}