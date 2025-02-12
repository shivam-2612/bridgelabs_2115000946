using System;

class Task
{
    public int TaskId;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;
    public Task Next;
}

class TaskScheduler
{
    private Task head, tail;

    public void AddTask(int id, string name, int priority, DateTime dueDate, int position = -1)
    {
        Task newTask = new Task { TaskId = id, TaskName = name, Priority = priority, DueDate = dueDate };
        if (head == null)
        {
            head = tail = newTask;
            tail.Next = head;
            return;
        }
        if (position == 0)
        {
            newTask.Next = head;
            head = newTask;
            tail.Next = head;
            return;
        }
        Task temp = head;
        int index = 1;
        while (temp.Next != head && (position == -1 || index < position))
        {
            temp = temp.Next;
            index++;
        }
        newTask.Next = temp.Next;
        temp.Next = newTask;
        if (temp == tail) tail = newTask;
    }

    public void RemoveTask(int id)
    {
        if (head == null) return;
        if (head.TaskId == id)
        {
            if (head == tail) { head = tail = null; return; }
            head = head.Next;
            tail.Next = head;
            return;
        }
        Task temp = head;
        while (temp.Next != head && temp.Next.TaskId != id)
        {
            temp = temp.Next;
        }
        if (temp.Next.TaskId == id)
        {
            temp.Next = temp.Next.Next;
            if (temp.Next == head) tail = temp;
        }
    }

    public void DisplayTasks()
    {
        if (head == null) return;
        Task temp = head;
        do
        {
            Console.WriteLine($"Task ID: {temp.TaskId}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due: {temp.DueDate}");
            temp = temp.Next;
        } while (temp != head);
    }

    public void ViewCurrentAndMoveNext()
    {
        if (head == null) return;
        Console.WriteLine($"Current Task: {head.TaskId} - {head.TaskName}");
        head = head.Next;
    }

    public Task SearchTaskByPriority(int priority)
    {
        if (head == null) return null;
        Task temp = head;
        do
        {
            if (temp.Priority == priority) return temp;
            temp = temp.Next;
        } while (temp != head);
        return null;
    }
}
