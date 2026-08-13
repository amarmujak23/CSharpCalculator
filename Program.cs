using System.Numerics;
using System.Threading.Channels;

Console.WriteLine("Calculator C# 1.0");
Console.WriteLine("--------------------");

// Parsing in C# converts a string to a number. int number = int.Parse("123"); // number is now 123

//This line calls a dictionary that contains the operations available in the calculator.
Dictionary<int, string> operations = new Dictionary<int, string>()
{
    {1, "Addition"},
    {2, "Subtraction"},
    {3, "Multiplication"},
    {4, "Division"},
    {5, "Square Root"}
};


string tryAgain = "yes";

// do statement is used to execute a block of code at least once,
// and then repeatedly execute the block as long as a specified condition is true.

do
{
    Console.Clear();
    //Prints menu 

    foreach (var operation in operations)
    {
        Console.WriteLine(operation);
    }

    Console.WriteLine("--------------------");

    // Using double data type to allow for decimal numbers
    double number1 = 0;
    double number2 = 0;


    Console.WriteLine("Select an operation by entering the corresponding number: ");

    int choice = int.Parse(Console.ReadLine());
    // string concatination
    // need to write error handling for when selecting a wrong operation
    if (choice < 1 || choice > 5)
    {
        Console.WriteLine("Invalid choice. Please select a valid operation.");
        Console.ReadKey();
        Console.Clear();
        continue;
    }

    Console.WriteLine("You selected: " + operations[choice]);


    Console.WriteLine("Enter the first number: ");
    number1 = double.Parse(Console.ReadLine());
    Console.Clear();


    if (choice != 5)
    {
        Console.WriteLine("Enter the second number: ");
        number2 = double.Parse(Console.ReadLine());
    }

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
    Console.WriteLine("Do you want to perform another operation? (yes/no): ");
    tryAgain = Console.ReadLine()!.Trim().ToLower();

}
while (tryAgain == "yes" || tryAgain == "y");

// && represents AND in C#
if (tryAgain != "yes" && tryAgain != "y") 
{
    Environment.Exit(0);
}

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