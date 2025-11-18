/* Rules
 The only allowed characters for identifiers are all alphanumeric characters([A-Z], [a-z], [0 - 9]), '_'(underscore).
 For example, "foo@" is not a valid C# identifier as it contain '@' – special character.

 Identifiers should not start with digits([0-9]).
 For example, "123bar" is not valid in the C# identifier.

 Identifiers must NOT contain whitespace characters.

 Identifiers are not allowed to use as keywords unless they include @ as a prefix.
 For example, @as is a valid identifier, but "as" is not because it is a keyword.

 C# identifiers allow Unicode Characters.

 C# identifiers are case-sensitive.

 C# identifiers cannot contain more than 512 characters.

 Identifiers do not contain two consecutive underscores in their name because such types of identifiers are used for the implementation. */


// Simple C# program to illustrate identifiers
using System;

namespace CSharpFundamentals.Basics {
    public class Indentifiers {
        static public void Init() {
            // variable
            int a = 10;
            int b = 39;
            int c;

            // basic operation
            c = a + b;

            Console.WriteLine("The sum of two number is: {0}", c);
        }
    }
}


