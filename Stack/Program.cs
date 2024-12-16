namespace Stack;

class Program
{
    static void Main()
    {
        var randomCreator = new RandomCreator();
        var newList = randomCreator.GetRandomList();
        var stack = new Stack<int>(newList.Item1);
        var rounds = randomCreator.GetRandomRounds();
        var player = new Player(stack, randomCreator);
        player.PlayWithRounds(rounds);

        stack.Clear();
        Console.WriteLine($"\nStack cleared. Is empty? {stack.IsEmpty()}");
    }
}