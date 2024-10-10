namespace MyUtilities
{
    internal class CalculatorUtilities
    {
        public static void UseCalculator()
        {
            double result = 0;
            var keepGoing = "";

            do
            {
                Console.WriteLine("Enter first operator: ");
                string readLine1stOperator = Console.ReadLine();
                double firstOperator = Convert.ToDouble(readLine1stOperator);

                Console.WriteLine("Enter second operator: ");
                string readLine2ndOperator = Console.ReadLine();
                double secondOperator = Convert.ToDouble(readLine2ndOperator);

                string test = "";

                Console.WriteLine("Enter what kind of operation you'd like to perform: (+, -, /, *)");
                string operationKind = Console.ReadLine();

                switch (operationKind)
                {
                    case "+":
                        result = DoSum(firstOperator, secondOperator);
                        Console.WriteLine($"Result is: {result}");
                        break;
                    case "-":
                        result = firstOperator - secondOperator;
                        Console.WriteLine($"Result is: {result}");
                        break;
                    case "*":
                        result = firstOperator * secondOperator;
                        Console.WriteLine($"Result is: {result}");
                        break;
                    case "/":
                        result = DoDivide(firstOperator, secondOperator);
                        Console.WriteLine($"Result is: {result}");
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

                Console.WriteLine("Would you like to do other operations? (Y/N)");
                var readLineWithoutCaseConversion = Console.ReadLine();
                keepGoing = readLineWithoutCaseConversion.ToUpper();
            } while (keepGoing == "Y");

            Console.WriteLine("Thanks for using the calculator!");
        }

        private static double DoDivide(double firstOperator, double secondOperator)
        {
            double product = 0;

            if (secondOperator == 0)
                Console.WriteLine("You cannot divide by 0");
            else
                product = firstOperator / secondOperator;

            return product;
        }

        private static double DoSum(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }
    }
}
