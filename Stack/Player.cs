namespace Stack;

public class Player
{
    private Stack<int> _stack;
    private RandomCreator _randomCreator;
    private Player()
    {

    }
    public Player(Stack<int> stack, RandomCreator randomCreator)
    {
        _stack = stack;
        _randomCreator = randomCreator;
    }
    public void PlayWithRounds(int rounds)
    {
        Console.WriteLine();
        for (int i = 0; i < rounds; i++)
        {
            Console.WriteLine($"Round:  {i + 1}");
            var newList = _randomCreator.GetRandomList();
            var numberofPops = _randomCreator.GetRandomRounds();
            _stack.PushList(newList.Item2);
            Console.WriteLine($"Pushing {newList.Item1} Items Inside Stack");
            _stack.PrintStackItems();
            Console.WriteLine($"Stack size: {_stack.Size()}");
            Console.WriteLine($"Stack top: {_stack.Peek()}");
            Console.Write($"Pop {numberofPops} Items From Stack");
            for (int j = 0; j < numberofPops; j++)
            {
                var lastItem = _stack.Pop();
                if (lastItem != default)
                {
                    Console.Write($"\nPopped element: {lastItem}");
                }
                else { Console.Write($"\nNo More elements to Pop"); }
            }
            var peekItem = _stack.Peek();
            if (peekItem != default)
            {
                Console.WriteLine($"\nTop element after pop: {peekItem}");
            }
            else { Console.WriteLine($"\nNo More elements at the top of stack"); }
            Console.WriteLine($"Is stack empty? {_stack.IsEmpty()}");
            Console.WriteLine();
        }
    }
}
