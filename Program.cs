using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AbilityScoreCalculator calculator = new AbilityScoreCalculator();

            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();

                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;

            }

        }


        public static int ReadInt(int lastUsedValue, string promt)
        {
            Console.Write($"{promt} [{lastUsedValue}]:");
            string newValue = Console.ReadLine();
            if(int.TryParse(newValue, out int newValueAsInt))
            {
                Console.WriteLine("     using value " + newValueAsInt);
                return newValueAsInt;
            }
            else
            {
                Console.WriteLine("     using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }

        public static double ReadDouble(double lastUsedValue, string promt)
        {
            Console.Write($"{promt} [{lastUsedValue}]:");
            string newValue = Console.ReadLine();
            if (double.TryParse(newValue, out double newValueAsDouble))
            {
                Console.WriteLine("     using value " + newValueAsDouble);
                return newValueAsDouble;
            }
            else
            {
                Console.WriteLine("     using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }



    }
}
