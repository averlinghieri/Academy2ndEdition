using System.Linq.Expressions;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double result = 0;
            //var keepGoing = "";

            //do
            //{
            //    Console.WriteLine("Enter first operator: ");
            //    string readLine1stOperator = Console.ReadLine();
            //    double firstOperator = Convert.ToDouble(readLine1stOperator);

                //    Console.WriteLine("Enter second operator: ");
                //    string readLine2ndOperator = Console.ReadLine();
                //    double secondOperator = Convert.ToDouble(readLine2ndOperator);

                //    string test = "";

                //    Console.WriteLine("Enter what kind of operation you'd like to perform: (+, -, /, *)");
                //    string operationKind = Console.ReadLine();

                //    switch (operationKind)
                //    {
                //        case "+":
                //            result = firstOperator + secondOperator;
                //            Console.WriteLine($"Result is: {result}");
                //            break;
                //        case "-":
                //            result = firstOperator - secondOperator;
                //            Console.WriteLine($"Result is: {result}");
                //            break;
                //        case "*":
                //            result = firstOperator * secondOperator;
                //            Console.WriteLine($"Result is: {result}");
                //            break;
                //        case "/":
                //            if (secondOperator == 0)
                //                Console.WriteLine("You cannot divide by 0");
                //            else
                //                result = firstOperator / secondOperator;
                //            Console.WriteLine($"Result is: {result}");
                //            break;
                //        default:
                //            Console.WriteLine("Invalid operation");
                //            break;
                //    }

                //    Console.WriteLine("Would you like to do other operations? (Y/N)");
                //    var readLineWithoutCaseConversion = Console.ReadLine();
                //    keepGoing = readLineWithoutCaseConversion.ToUpper();
                //} while (keepGoing == "Y");

                //Console.WriteLine("Thanks for using the calculator!");

                //int[] numbers = { 5, 7, 9, 2, 8, 9 };

                //int maxValue = 0; //valore iniziale per inzializzare
                //int secondMaxValue = 0; //valore iniziale per inzializzare

                //for (int index = 0; index < numbers.Length; index++)
                //{
                //    if (numbers[index] > maxValue)
                //    {
                //        secondMaxValue = maxValue;
                //        maxValue = numbers[index];
                //    }
                //    else if (numbers[index] > secondMaxValue && numbers[index] != maxValue)
                //    {
                //        secondMaxValue = numbers[index];
                //    }
                //}

                //Console.WriteLine($"Second max value is: {secondMaxValue}");


            var random = new Random();
            int solution = random.Next(0, 101);
            int guess = 0;
            const int maxAttempts = 5;
            int attempts = 0;

            Console.WriteLine("Try to guess the number! (0-100)");
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

            //Creare giochino in cui bisogna indovinare il numero salvato nella variabile solution
            //Il programma continuerà a dire se numero inserito da utente è più grande o più piccolo
            //di solution, e l'utente continuerà a inserire numeri finché non indovina solution con 
            //messagio di congratulazioni
        }

    }
}