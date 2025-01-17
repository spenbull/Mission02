namespace Mission02;

public class DiceRoller
{
    private Random random = new Random();

    public int[] SimulateRolls(int numberOfRolls)
    {
        int[] rollResults = new int[13]; 

        for (int i = 0; i < numberOfRolls; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int sum = die1 + die2;
            rollResults[sum]++;
        }

        return rollResults;
    }
}