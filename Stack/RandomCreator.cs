namespace Stack;

public class RandomCreator()
{
    public (int, List<int>) GetRandomList()
    {
        var random = new Random();
        var size = random.Next(1, 10);

        var randomNumbers = new List<int>();
        for (int i = 0; i < size; i++)
        {
            randomNumbers.Add(random.Next(1, 10000));
        }

        return (size, randomNumbers);
    }
    public int GetRandomRounds()
    {
        var random = new Random();
        return random.Next(1, 10);
    }
}