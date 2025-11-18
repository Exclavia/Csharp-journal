/*
 Data Types in C# is Mainly Divided into 3 Categories:
 - Value Data Types
 - Reference Data Types
 - Pointer Data Type


Value Types

                                Signed & Unsigned Integral Types
  Alias	     .NET Type	          Type	        Size(bits)	       Range	      Default Value
-------------------------------------------------------------------------------------------------
| sbyte	    System.SByte	    signed int	        8	        -128   - 127	        0       |
| short	    System.Int16	    signed int	        16	        -32768 - 32767	        0       |
| int	    System.Int32	    signed int	        32	        -231   - 231-1	        0       |
| long	    System.Int64	    signed int	        64	        -263   - 263-1	        0L      |
| byte	    System.Byte	        unsigned int	    8	         0     - 255	        0       |
| ushort	System.UInt16	    unsigned int	    16	         0     - 65535	        0       |
| uint	    System.UInt32	    unsigned int	    32	         0     - 232	        0       |
| ulong	    System.UInt64	    unsigned int	    64	         0     - 263	        0UL     |
-------------------------------------------------------------------------------------------------

                                        Floating Point Types
  Alias	        .NET Type	        Size(bits)	            Range (aprox)	        Default Value
---------------------------------------------------------------------------------------------------
| float	        System.Single	        32	        ±1.5 × 10-45 to ±3.4 × 1038	        0.0F      |
| double	    System.Double	        64	        ±5.0 × 10-324 to ±1.7 × 10308	    0.0D      |
---------------------------------------------------------------------------------------------------

                                             Decimal Types
  Alias	         Type name	        Size(bits)	            Range (aprox)	            Default Value
-------------------------------------------------------------------------------------------------------
| decimal	    System.Decimal	        128	        ±1.0 × 10-28 to ±7.9228 × 1028  	    0.0M      |
-------------------------------------------------------------------------------------------------------

                                        Character Types
  Alias	         Type name	        Size In(Bits)	        Range	            Default value
-----------------------------------------------------------------------------------------------
| char	        System.Char	            16	           U +0000 to U +ffff	         '\0'     |
-----------------------------------------------------------------------------------------------
 
                    Boolean Types
  Alias           Type Name           Possible Values
------------------------------------------------------
| bool          System.Boolean         true / false  |
------------------------------------------------------



Reference Types

                       String
string s1 = "hello"; // creating through string keyword  
String s2 = "welcome"; // creating through String class  


Pointer Data Type

The Pointer Data Types will contain a memory address of the variable value. To get the pointer details we have a two symbols ampersand (&) and asterisk (*).
 - ampersand (&): It is known as Address Operator. It is used to determine the address of a variable.
 - asterisk (*): It also known as Indirection Operator. It is used to access the value of an address.

type* identifier;

int* p1, p;     // Valid syntax 
int *p1, *p;    // Invalid
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Basics {
    public class DataTypes {
        static public void ValTypes() {
            // declaring character
            char a = 'G';
            // Integer data type is generally used for numeric values
            int i = 89;
            short s = 56;
            // long uses Integer values which may signed or unsingned
            long l = 4564;
            // UInt data type is generally used for unsingned integer values
            uint ui = 95;
            ushort us = 76;
            // ulong data type is generally for unsingned integer values
            ulong ul = 3624573;
            // by default fraction value is double in C#
            double d = 8.358674532;
            // for float use 'f' as suffix
            float f = 3.7330645f;
            // for float use 'm' as suffix
            decimal dec = 389.5m;

            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsingned integer: " + ui);
            Console.WriteLine("Unsingned short: " + us);
            Console.WriteLine("Unsingned long: " + ul);


            // Sbyte signed integral data type
            sbyte b = 126;
            // sbyte is 8 bit singned value
            Console.WriteLine(b);
            b++;
            Console.WriteLine(b);
            // It overflows here because byte can hold values from -128 to 127
            b++;
            Console.WriteLine(b);
            // Looping back within the range
            b++;
            Console.WriteLine(b);

            // Byte data type
            byte c = 0;
            // byte is 8 bit unsigned vclue
            Console.WriteLine(c);
            c++;
            Console.WriteLine(c);
            c = 254;
            // It overflows here beccuse byte ccn hold vclues from 0 to 255
            c++;
            Console.WriteLine(c);
            // Looping bcck within the rcnge
            c++;
            Console.WriteLine(c);


            // boolean data type
            bool e = true;

            if (e == true) { 
                Console.WriteLine("Hi there!");
        }

    }

        static public void RefTypes() {
            // declaring string
            string a = "Hello";

            // append in a
            a += ", how";
            a = a + " are you?";
            Console.WriteLine(a);

            // declare object obj
            object obj;
            obj = 20;
            Console.WriteLine(obj);

            // to show type of object using GetType()
            Console.WriteLine(obj.GetType());
        }

        static public void PointerTypes() {
            unsafe {
                // declare variable
                int n = 10;
                // store variable n address location in pointer variable p
                int* p = &n;
                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}", (int)p);
            }
        }
    }
}
