/*

Characteristics of Variables
 - name : It must be a valid identifier. In above example, var is a valid identifier.
 - type : It defines the types of information which is to be stored into the variable.

Rules for Naming Variables
 - Variable names can contain the letters ‘a-z’ or ’A-Z’ or digits 0-9 as well as the character ‘_’.
 - The name of the variables cannot be started with a digit.
 - The name of the variable cannot be any C# keyword say int, float, null, String, etc.

Defining or Declaring a Variable
There are some rules that must be followed while declaring variables:
 - Specify its type (such as int)
 - Specify its name (such as age)
 - Can provide initial value(such as 17)

Examples:
type variable_name = value;     // Method 1
type variable_names;            // Method 2
-----------------------------------------------------------------------------
int y = 7;        // Declaring and initializing the variable at same time
int x;            // Declaring variable x
x = 5;            // Initializing x with value 5


+ Literals

In C#, a literal is a fixed value used in a program.
These values are directly written into the code and can be used by variables.
A literal can be an integer, floating-point number, string, character, boolean, or even null.

For the sake of time and space, I won't reiterate variable definitions.

Example:
// Here 100 is a literal.
int x = 100;


+ Constants
If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type.
This will declare the variable as "constant", which means unchangeable and read-only:
const int myNum = 15;
myNum = 20; // error
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpFundamentals.Basics {
    public class Variables {
        // only declaration, compiler will 
        // provide the default value 0 to it
        int y;
        const double pi = 3.14;

        // Compile Time Initialization
        public static void CompileTimeInit() {
            int x = 32;

            // Printing the value
            Console.WriteLine("Value of x is " + x);

            // Creating object to access
            // the variable y
            Variables var = new Variables();

            // Printing the value
            Console.WriteLine("Value of y is " + var.y);
            Console.WriteLine("Pi is: " + pi);
        }


        // Run Time Initialization
        public static void RunTimeInit() {
            {
                // Value will be taken from user 
                // input and assigned to variable
                // num
                Console.Write("Input Number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                // printing the result
                Console.WriteLine("Value of num is " + num);
            }
        }
    }
}
