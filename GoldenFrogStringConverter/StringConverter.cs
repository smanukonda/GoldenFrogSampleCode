using System;
using System.Linq;
using System.Text;

namespace GoldenFrogStringConverter
{
    /// <summary>
    /// Helper class to manipulate elements of an array
    /// </summary>
    public class StringConverter
    {
        private static readonly char[] Vowels = { 'A', 'E', 'I', 'O', 'U' };

        /// <summary>
        /// Reverses all characters of the string and then converts every consonant to lower case 
        /// and every vowel to upper case.
        /// </summary>
        /// <param name="stringToConvert">stringToConvert</param>
        /// <returns>Reverse ordered and converted string</returns>
        public static string ConvertInput(string stringToConvert)
        {
            //Stringbuilder is used instead of string to avoid creating unnecessary string objects in every iteration 
            var strBuilder = new StringBuilder(stringToConvert.Length);

            // iterate chars
            for (var i = stringToConvert.Length - 1; i > -1; i--)
            {
                var chr = stringToConvert[i];

                if (Vowels.Contains(Char.ToUpper(chr)))
                {
                    //Element is a vowel
                    if (Char.IsLower(chr))
                        chr = Char.ToUpper(chr);
                }
                else
                {
                    //Element is a consonant
                    if (Char.IsUpper(chr))
                        chr = Char.ToLower(chr);
                }

                // append char to string
                strBuilder.Append(chr);
            }

            return strBuilder.ToString();
        }

        /*
       // Written the below peice of code if you literally mean passing a char array as an argument and then converting it
        /// <summary>
        /// Reverses elements of a character array and then converts every consonant to lower case 
        /// and every vowel to upper case.
        /// </summary>
        /// <param name="array">character array</param>
        /// <returns>Reverse ordered and converted array</returns>
        public static char[] ReverseElementsAndConvert(params char[] array)
        {           

            //Reverse the array elements
            Array.Reverse(array);

            //The reversed array elements are verified for vowels or consonants. 
            //Vowels are converted to upper case and consonantsenadu are converted to lower case.
            for (int i = 0; i < array.Length; i++)
            {
                if (Vowels.Contains(Char.ToUpper(array[i])))
                {
                    //Element is a vowel
                    if (Char.IsLower(array[i]))
                        array[i] = Char.ToUpper(array[i]);
                }
                else
                {
                    //Element is a consonant
                    if (Char.IsUpper(array[i]))
                        array[i] = Char.ToLower(array[i]);
                }
            }

            return array;
        }
         */
    }
}
