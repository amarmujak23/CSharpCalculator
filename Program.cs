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

Console.ReadLine();





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