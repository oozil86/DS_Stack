namespace Stack;

public class Stack<T>
{
    private int top;
    private T[] items;
    private int _size;
    private int itemscount;

    private Stack() { }
    public Stack(int size = 10)
    {
        top = -1;
        _size = size;
        items = new T[size];
        itemscount = 0;
    }
    public bool IsEmpty()
    {
        return top == -1;
    }
    public void Push(T item)
    {
        if (top == _size - 1)
        {
            Resize();
        }
        items[++top] = item;
        itemscount++;
    }
    private void Resize()
    {
        _size += 2;
        var newArr = new T[_size];
        Array.Copy(items, newArr, items.Length);
        items = newArr;
    }
    public int Size()
        => top + 1;
    public T Peek()
    {
        try
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            return items[top];
        }
        catch
        {
            return default;
        }

    }
    public T Pop()
    {
        try
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");
            var item = items[top];
            items[top--] = default;
            itemscount--;
            return item;
        }
        catch
        {
            return default;
        }
    }
    public void Clear()
    {
        top = -1;
        items = new T[_size];
    }
    public void PrintStackItems()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");
        Console.Write("Stack Items : ");
        Console.WriteLine(string.Join(",", items.Take(itemscount)));
    }
    public void PushList(List<T> newItems)
    {
        foreach (var newItem in newItems)
        {
            if (top == _size - 1)
            {
                Resize();
            }
            items[++top] = newItem;
            itemscount++;
        }

    }
}
