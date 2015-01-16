using System;

namespace GoldenFrogStringConverter
{
    class Program
    {

        static void Main(string[] args)
        {          
             
            Console.WriteLine("Please enter a valid string.");
            // Read the input from console
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a valid string. You have two more attempts.");
                int j = 1;
                for (int i = 2; i >0; i--)
                {

                    Console.WriteLine("Attempt {0}:", j);
                    input = Console.ReadLine();

                    if (!string.IsNullOrEmpty(input))
                        break;
                    if (i != 0)
                    {
                        j++;
                        continue;
                    }                    
                    Console.WriteLine("Exiting");
                }
            }
            Console.WriteLine();
            //Calls Converter function and prints the output
            Console.WriteLine("Converted String: {0}",StringConverter.ConvertInput(input));

            Console.ReadKey();
        }        
    }
}
