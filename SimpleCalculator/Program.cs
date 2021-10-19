using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // ConditionalStatement();
            // Strings();
            // ConditionalStatement();
            Exceptions();

            // Classes and Objects: custom types.
            // person1 and person2 will have separate spots in the memory.
            //Person person1 = new Person();
            //Person person2 = new Person();

            //Console.WriteLine(person1.getAge());
            //person1.setAge(29);
            //Console.WriteLine(person1.getAge());
            //Person.greet();
            //Console.ReadLine();

        }

        static void Conversion()
        {
            /* Converting Strings to Numbers 
               Expressions and Operators
               Variables */

            string input = Console.ReadLine();

            int convertedInputToNumber;
            int.TryParse(input, out convertedInputToNumber);

            int number = 90;
            int result = 10 + 10 - 100 + 1000 - number + convertedInputToNumber;

            /* Order of Evaluation - Operator precedence and operator associativity 
             * Evaluate expressions starting with the ones with high precedings and working down to the lower ones. 
             * Operators with the same precedence rely on operator associativity...
             * example multiply and division might be left to right, but you can change the order using ()
            */

            //int result = 20 + 5 * 2;
            Console.WriteLine(result);
        }

        static void Strings()
        {
            /* Strings */
            string someText = "Here is Some text";
            string someOtherText = "Here is some text";

            bool isEqual = someText.Equals(someOtherText, StringComparison.OrdinalIgnoreCase);

            string addedText = someText + " " + someOtherText + " here is some more text.";
            string formattedString = string.Format("{0} {1} here is some more text.", someText, someOtherText);

            Console.WriteLine(addedText);
            Console.WriteLine(formattedString);

            // String Indexes and Properties
            Console.WriteLine(someText.Length);
            Console.WriteLine(someText[8]);

            // Substring, get a part of the string
            Console.WriteLine(someText.Substring(8, 4));

            Console.WriteLine(someText.ToLower());
            Console.WriteLine(someText.ToUpper());

            string anotherText = string.Empty; // Instead of using string literals "" (empty string)

            string replacedText = someText.Replace("text", "string");

            Console.WriteLine(replacedText);

            Console.ReadLine();
        }

        static void ConditionalStatement()
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            // Can work with multiple variables..username and password
            if (username.Equals("Avetis") && password.Equals("abc123"))
            {
                Console.WriteLine("Hello Admin");
            }
            else if (username.Equals("Joe") && password.Equals("abc124"))
            {
                Console.WriteLine("Hello Moderator!");
            }
            else
            {
                Console.WriteLine("Hello Guest!");
            }

            // Works with only one input, username..unable to use password... 
            // Can use it with Switch but you need a workaround.
            switch (username)
            {
                case "Avetis":
                    Console.WriteLine("Hello Admin!");
                    break;
                case "Joe":
                    Console.WriteLine("Hello Moderator");
                    break;
                default:
                    Console.WriteLine("Hello Guest!");
                    break;
            }

            Console.ReadLine();

        }

        static void Exceptions()
        {
            try
            {
                Exception myFirstException = new Exception();
                string input = Console.ReadLine();

                int convertedNumber;
                bool isConvertedSucessfully = int.TryParse(input, out convertedNumber);

                if (!isConvertedSucessfully)
                {
                    throw new Exception("Conversion was not successful.");
                    // Best practise for the stack call is to throw; or throw with new excaption
                    // especially when sending an exception outside it's method
                }
            } catch (Exception ex)
            {
                Console.WriteLine("There was an error: {0}", ex.Message);
            } finally // Run any code whether there was an exception or not, maybe to free up any resources
            {
                Console.WriteLine("The rest of my application is still running");
            }

            // You do not want to have another code after a try catch


            Console.ReadLine();
        }
    }
}