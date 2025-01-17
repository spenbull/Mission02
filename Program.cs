// See https://aka.ms/new-console-template for more information

namespace Mission02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of times you want to roll the dice: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfRolls) && numberOfRolls > 0)
            {
                DiceRoller roller = new DiceRoller();
                int[] results = roller.SimulateRolls(numberOfRolls);

                Console.WriteLine("\nHistogram of Dice Rolls:");
                for (int i = 2; i <= 12; i++)
                {
                    int percentage = (int)((results[i] / (double)numberOfRolls) * 100);
                    Console.WriteLine($"{i}: {new string('*', percentage)}");
                }
            }
            else
            {
                Console.WriteLine("Enter a positive integer.");
            }
        }
    }
}