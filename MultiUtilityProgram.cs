using MyUtilities;

namespace MyFirstProgram
{
    internal class MultiUtilityProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Multi Utility Program! \n" +
                "What kind of utility do you wish to use? \n");

            Console.WriteLine("1 - Calculator \n" +
                "2 - Find Second Max Value \n" +
                "3 - Guess The Number Game \n" +
                "4 - Weather Report \n" +
                "5 - Count Wowels \n" +
                "6 - Reverse Sentence");

            var menuChoice = Console.ReadKey().KeyChar;

            Console.WriteLine("\n");


            switch (menuChoice)
            {
                case '1':
                    CalculatorUtilities.UseCalculator();
                    break;
                case '2':
                    int[] array = [1, 8, 6, 7, 7, 9];
                    ArrayUtilities.FindSecondMaxValue(array);
                    break;
                case '3':
                    GamesUtilities.GuessTheNumber();
                    break;
                case '4':
                    WeatherUtilities.Report(
                        humidity: 91f,
                        location: "San Francisco",
                        temperatureCelsius: WeatherUtilities.ConvertFahrenheitToCelsius(58f)
                        );
                    break;
                case '5':
                    ArrayUtilities.CountVowels();
                    break;
                case '6':
                    ArrayUtilities.ReverseSentence();
                    break;
                default:
                    Console.WriteLine("Selection is not supported");
                    break;
            }
        }
    }
}