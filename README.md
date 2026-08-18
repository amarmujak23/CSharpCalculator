# C# Calculator

A simple console-based calculator written in C# (.NET 10 / C# 14) that supports addition, subtraction, multiplication, division, and square root operations. The program validates user input and repeats until the user chooses to exit.

## Features
- Menu-driven console UI showing available operations
- Supports decimal numbers (double)
- Input validation for operation selection and numeric input
- Division-by-zero and square-root-of-negative checks with error messages
- Repeats automatically when the user answers "yes" to continue

## Requirements
- .NET 10 SDK
- C# 14 compatible compiler

## Build and run
1. Open a terminal in the project folder.
2. Build and run with dotnet:

   dotnet run --project CSharpCalculator

Alternatively, open the project in Visual Studio 2022 (or newer) that supports .NET 10.

## Usage
1. Run the program.
2. Select an operation by entering its number from the displayed menu.
3. Enter the required number(s). The program will prompt again on invalid numeric input.
4. After showing the result, the program will ask whether you want to perform another operation. Enter `yes`/`y` to continue or `no`/`n` to exit. Any other response will prompt for a valid answer.

## Notes and behavior
- When performing division, if the second number is zero the program prints an error warning.
- Square root of a negative number prints an error warning.
- The program uses input loops to ensure the user provides valid responses before proceeding.

## Future tasks
- Validate whether the calculation is allowed before displaying its result.
