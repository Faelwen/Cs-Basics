using System;

namespace CsPrimitiveTypesAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //**************************
            // Comments
            //**************************
            // Comments in C# an be :
            //  single-line (//)
            //  multi-line  (/* */)

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

            // Instead of specifying a type, var can be used. C# will automatically guess the proper type from the initial value :
            var isTrue = true;   // isTrue will be automatically declared as a boolean
            var character = 'C'; // character will automatically be declared as a char

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

            //********************
            // Write to console
            //********************
            // Writing to console can be done with Console.WriteLine()
            // In Visual Studio it can written very quickly with the code snipet cw (type "cw" then double tab)
            //
            int number5 = 2;
            Console.WriteLine(number5);

            // Format strings can be used with {n} as placeholder :
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //********************
            // Type conversion 
            //********************
            //
            // Type conversion can be implicit when conversion between types is easy.
            // For instance, a byte can be easily converted into an int :
            byte b2 = 1;
            int i = b2;

            //... or an int to a float
            int i2 = 1;
            float f = i2;

            // However an int cannot be conveted to a byte implicitly
            // Neither can a float to an int
            // In these cases, conversion can be done by casting :
            int i3 = 1;
            byte b3 = (byte)i3;

            float f2 = 1.0f;
            int i4 = (int)f2;

            // In cases where data-types are not directly compatible, such as int and string, there are various special functions that can do the conversion :
            string s = "1";
            int j = Convert.ToInt32(s); // one possibility
            int k = int.Parse(s);       // another possibility

            //********************
            // Operators 
            //********************
            // Arthmetic operators :
            //  Add       : +
            //  Subtract  : - 
            //  Multiply  : *
            //  Divide    : /
            //  Remainder : %
            //  Increment : ++
            //  Decrement : --
            //
            // Comparaison operators :
            //  Equal                    : ==
            //  Not Equal                : !=
            //  Greater than             : >
            //  Greater than or equal to : >=
            //  Less than                : <
            //  Less than or equal to    : <=
            //
            // Assignment operators :
            //  Assign         : =
            //  Addition       : +=
            //  Subtraction    : -=
            //  Multiplication : *=
            //  Division       : /=
            //
            // Logical operators :
            //  And : &&
            //  Or  : ||
            //  Not : !
            //
            // Bitwise operators :
            //  And : &
            //  Or  : |


            //********************
            // Arrays 
            //********************
            // Declare an array :
            int[] numbers = new int[3]; // elements are initialised at 0 by default

            // Assign or access specific items in an array by index :
            numbers[0] = 2; // in C#, first element of an array is indexed at 0
            numbers[1] = 5;

            // Assign at declaration:
            int[] numbers2 = new int[3] { 1, 2, 3 };


            //********************
            // Strings 
            //********************
            //
            // Declare a string :
            string firstName = "qdfdsf";
            string lastName = "dgqrehg";

            // Concatenation :
            string name = firstName + " " + lastName;

            // String format :
            string name2 = string.Format("{0} {1}", firstName, lastName);

            // Join string from array :
            string list = string.Join(",", numbers);

            // Escape characters : \n, \t, \\, \' and \"
            // Escape characters can be avoided using a verbatim string using a @ :
            string path = @"C:\users\folder";
        }
    }

    //********************
    // Classes 
    //********************
    //
    // Declaring a class :

    public class Person
    {
        //declare class variables
        public string Name;

        //declare class methods:
        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name);
        }


        // adding the static keyword when declaring a method allows to access it without having to create an instance of an object.
        static void TestClass()
        {
            // to creating an object from a class, use the new keyword :
            Person person = new Person();

            // Call variable or property of an objct : use dot
            person.Name = "";
            person.Introduce();
        }
    }

    //********************
    // Structs 
    //********************
    //
    // Declaring a struct is like a class :
    public struct Structure
    {
        public int x;
        public int y;
        public int z;
    }
}
