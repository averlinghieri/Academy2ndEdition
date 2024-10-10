using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilities
{
    internal class GamesUtilities
    {
        public static void GuessTheNumber()
        {
            var random = new Random();
            int solution = random.Next(0, 101);
            int guess = 0;
            const int maxAttempts = 5;
            int attempts = 0;

            Console.WriteLine("Try to guess0 the number! (0-100)");
            do
            {
                var readNumber = Console.ReadLine();
                guess = Convert.ToInt32(readNumber);
                attempts++;

                if (guess > solution)
                    Console.WriteLine("Too high!");
                else if (guess < solution)
                    Console.WriteLine("Too low!");
            } while (guess != solution && attempts != maxAttempts);

            if (guess == solution)
                Console.WriteLine("Congratulations, you won!");
            else
                Console.WriteLine("Too bad, you lost!");
        }
    }
}
