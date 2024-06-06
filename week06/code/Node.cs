public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value == Data)
            return;
        else
        {
            if (value < Data)
            {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else
            {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }

    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
            return true;
        else if (value < Data)
            return Left is not null && Left.Contains(value);
        else
            return Right is not null && Right.Contains(value);
    
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (Left is null && Right is null)
            return 1;
        else if (Left is null)
            return 1 + Right.GetHeight();
        else if (Right is null)
            return 1 + Left.GetHeight();
        else
        {
            int leftHeight = Left.GetHeight();
            int rightHeight = Right.GetHeight();
            return 1 + (leftHeight > rightHeight ? leftHeight : rightHeight);
        }
    }
}