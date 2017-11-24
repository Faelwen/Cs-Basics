using System;

namespace CsPrimitiveTypesAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //**************************
            // Variables and Constants
            //**************************

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

            //********************
            // Overflowing
            //********************

            // In C# overflowing will bring the variable to its lowest possible value. 
            byte number3 = 255;
            number3++; // overflow, number3 wilkl contain zero

            // By default C# doesn't check overflows. The checked keyword can be used for that purpose:
            checked
            {
                byte number4 = 255;
                number4++; // overflow, an exception is thrown
            }

            //********************
            // Scope
            //********************
            // In C#, blocks are indicated with {}
            // A variable's scope is limited to the block in which it is defined.
            {
                byte a = 1;
                // Here a is accessible
                {
                    byte b = 2;
                    // Here a and b are accessible
                    {
                        byte c = 3;
                        // Here a, b and c are accessible
                    }
                    // Here c is no longer accessible
                }
                // Here b is no longer accessible
            }
            // Here a is no longer accessible



        }
    }
}
