using System;

namespace CsPrimitiveTypesAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Identifiers in C# cannot start with a number, nor include a whitespace.
            // An identifer cannot be a reserved keyword. If necessary it can be prefixed with an "@".

            // In most programming languages, usual naming conventions for variables are:
            // Camel case         : firstName
            // Pascal case        : FirstName
            // Hungarian notation : strFirstName (rarely used in C#)

            // The most used primitive types in C# are :
            // - byte, short, int and long for integers
            // - float, double and decimal for real numbers
            // - char for characters
            // - bool for booleans

            // Declare an integer variable
            int number;

            // Declare an integer variable and assign a variable
            int number2 = 1;

            // Declare and initialise a float constant
            // In C#, double is the default for real numbers, so values that are float or decimal must be suffixed to explicitly specify the format.
            // f for float, m for decimal
            const float Pi = 3.14f;
        }
    }
}
