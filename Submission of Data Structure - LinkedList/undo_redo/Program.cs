using System;

class TextState
{
    public string Content;
    public TextState Next, Prev;
}

class TextEditor
{
    private TextState current;

    public void AddState(string content)
    {
        TextState newState = new TextState { Content = content };
        if (current != null)
        {
            newState.Prev = current;
            current.Next = newState;
        }
        current = newState;
    }

    public void Undo()
    {
        if (current?.Prev != null) current = current.Prev;
    }

    public void Redo()
    {
        if (current?.Next != null) current = current.Next;
    }

    public void DisplayCurrentState()
    {
        if (current != null) Console.WriteLine(current.Content);
    }
}
