using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double n1, double n2, string operation)
        {
            double result = double.NaN;

            switch (operation)
            {
                case "a":
                    result = n1 + n2;
                    break;

                case "s":
                    result = n1 - n2;
                    break;

                case "m":
                    result = n1 * n2;
                    break;

                case "mod":
                    result = n1 % n2;
                    break;

                case "d":
                    if (n2 != 0)
                    {
                        result = n1 / n2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            bool closeApp = false;

            //Display the title for your Calculator app
            Console.WriteLine("Quick Calculator app with C# \r");
            Console.WriteLine("--------------------\n");

            while (!closeApp)
            {
                //Declare and initialize the variables
                string n1 = "";
                string n2 = "";
                double result = 0;

                //Ask user to input first number
                Console.WriteLine("Enter your first number and press Enter key..");
                n1 = Console.ReadLine();

                //to check the integer value
                double cleanNum1 = 0;

                while (!double.TryParse(n1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    n1 = Console.ReadLine();
                }

                //Ask user to input second number
                Console.WriteLine("Enter your seconds number and press Enter key..");
                n2 = Console.ReadLine();

                //to check the integer value
                double cleanNum2 = 0;
                while (!double.TryParse(n2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    n2 = Console.ReadLine();
                }
                //Ask which operation to perform
                Console.WriteLine("Choose which operation you would want to perform:");
                Console.WriteLine("\ta - ADD");
                Console.WriteLine("\ts - SUB");
                Console.WriteLine("\tm - MUL");
                Console.WriteLine("\td - DIV");
                Console.WriteLine("\tmod - MOD");
                Console.Write("Enter your option: ");

                string operation = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, operation);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("--------------------\n");

                //Wait for the user to input something to close the app
                Console.Write("Press 'n' and Enter or any key to close the app \n");
                if(Console.ReadLine() == "n")
                {
                    closeApp = true;
                }
                Console.WriteLine("\n");
            }
            return;
        }
    }
}
