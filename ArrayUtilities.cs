using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilities
{
    internal class ArrayUtilities
    {
        public static void FindSecondMaxValue(int[] integerArray)
        {
            int maxValue = 0; //valore iniziale per inzializzare
            int secondMaxValue = 0; //valore iniziale per inzializzare

            for (int index = 0; index < integerArray.Length; index++)
            {
                if (integerArray[index] > maxValue)
                {
                    secondMaxValue = maxValue;
                    maxValue = integerArray[index];
                }
                else if (integerArray[index] > secondMaxValue && integerArray[index] != maxValue)
                {
                    secondMaxValue = integerArray[index];
                }
            }

            Console.WriteLine($"Second max value is: {secondMaxValue}");
        }

        public static void CountVowels()
        {
            //string test = "pippo";
            //char[] testArray = ['p', 'i', 'p', 'p', 'o'];

            Console.WriteLine("Please enter a word or sentence for vowel count: \n");
            string wordInput = Console.ReadLine();
            int vowelsCount = 0;
            string vowels = "aeiou";

            for (int index = 0; index < wordInput.Length; index++)
            {
                if (vowels.Contains(wordInput[index]) == true)
                    vowelsCount++;
            }

            Console.WriteLine($"Total number of vowels: {vowelsCount}");
        }

        public static void ReverseSentence()
        {
            string reversedSentence = "";

            Console.WriteLine("Enter the sentence to reverse: \n");
            string readInput = Console.ReadLine();

            string[] temporaryValues = readInput.Split(' ');

            //Altro modo usando i metodi delle stringhe: 

            //Array.Reverse(temporaryValues);
            //reversedSentence = string.Join(" ", temporaryValues);

            int maxIndex = temporaryValues.Length - 1;

            while (maxIndex >= 0)
            {
                reversedSentence = reversedSentence + temporaryValues[maxIndex] + " ";
                maxIndex--;
            }

            Console.WriteLine($"Reversed sentence is: {reversedSentence}");
        }
    }
}
