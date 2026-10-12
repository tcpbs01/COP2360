using System;

namespace DivisionHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___ Number Division Program ___");

            Console.Write("Enter your first number: ");
            string firstInput = Console.ReadLine();

            Console.Write("Enter your second number: ");
            string secondInput = Console.ReadLine();

            try
            {
                int finalResult = DivideThemStrings(firstInput, secondInput);
                Console.WriteLine($"Result: {firstInput} divided by {secondInput} = {finalResult}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please make sure both inputs are valid whole numbers.");
                Console.WriteLine($"Error info: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: You cannot divide a number by zero.");
                Console.WriteLine($"Error info: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: The number you entered is too large or too small.");
                Console.WriteLine($"Error info: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error has occurred.");
                Console.WriteLine($"Error info: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit the program...");
            Console.ReadKey();
        }

        static int DivideThemStrings(string str1, string str2)
        {
            int numberOne = Convert.ToInt32(str1);
            int numberTwo = Convert.ToInt32(str2);

            return numberOne / numberTwo;
        }
    }
}
