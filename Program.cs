using System.Numerics;
using System.Threading.Channels;

string intro = "Calculator C# 1.0";

// Parsing in C# converts a string to a number.

//This line calls a dictionary that contains the operations available in the calculator.
Dictionary<int, string> operations = new Dictionary<int, string>()
{
    {1, "Addition"},
    {2, "Subtraction"},
    {3, "Multiplication"},
    {4, "Division"},
    {5, "Square Root"}
};


//Prints menu 

foreach (var operation in operations)
{
    Console.WriteLine(operation);
}

<<<<<<< HEAD
Console.WriteLine("--------------------");

// Using double data type to allow for decimal numbers
double number1 = 0;
double number2 = 0;


Console.WriteLine("Select an operation by entering the corresponding number: ");

int choice = int.Parse(Console.ReadLine());
// string concatination
Console.WriteLine("You selected: " + operations[choice]);

Console.WriteLine("Enter the first number: ");
number1 = double.Parse(Console.ReadLine());
Console.Clear();

Console.WriteLine("Enter the second number: ");
number2 = double.Parse(Console.ReadLine());
Console.Clear();



// Using switch statement to handle the selected operation from dictionary
switch (choice)
{
    case 1:
        double add = number1 + number2;
        Console.WriteLine($"The result of {operations[choice]} is: {add}");
        break;
    case 2:
        double sub = number1 - number2;
        Console.WriteLine($"The result of {operations[choice]} is: {sub}");
        break;
    case 3:
        double mul = number1 * number2;
        Console.WriteLine($"The result of {operations[choice]} is: {mul}");
        break;
    case 4:
        double div = number1 / number2;
        Console.WriteLine($"The result of {operations[choice]} is: {div}");
        break;
    case 5:
        double sqrt = Math.Sqrt(number1);
        Console.WriteLine($"The result of {operations[choice]} is: {sqrt}");
        break;
}



// string interpolation
// Console.WriteLine($"You selected: {operations[choice]}");

=======
Console.ReadLine();
>>>>>>> 0e7abd81ce044aacd0600cfa1b4d17aae7cea9ec



// Testing key
Console.ReadKey();

/*

int number1 = 0;
int number2 = 0;

Console.WriteLine("Enter the first number: ");
number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
number2 = int.Parse(Console.ReadLine());


int sum = number1 + number2;

Console.WriteLine("The sum is: "  + sum + " when adding!"); 
*/