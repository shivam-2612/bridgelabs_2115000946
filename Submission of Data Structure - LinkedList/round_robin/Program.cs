using System;

class Process
{
    public int ProcessID;
    public int BurstTime;
    public int Priority;
    public Process Next;
}

class Scheduler
{
    private Process head, tail;

    public void AddProcess(int id, int burst, int priority)
    {
        Process newProcess = new Process { ProcessID = id, BurstTime = burst, Priority = priority };
        if (head == null)
        {
            head = tail = newProcess;
            tail.Next = head;
            return;
        }
        tail.Next = newProcess;
        tail = newProcess;
        tail.Next = head;
    }

    public void ExecuteRoundRobin(int timeQuantum)
    {
        if (head == null) return;
        Process temp = head;
        do
        {
            if (temp.BurstTime > timeQuantum)
            {
                temp.BurstTime -= timeQuantum;
            }
            else
            {
                RemoveProcess(temp.ProcessID);
            }
            temp = temp.Next;
        } while (temp != head);
    }

    public void RemoveProcess(int id)
    {
        if (head == null) return;
        if (head.ProcessID == id)
        {
            if (head == tail) { head = tail = null; return; }
            head = head.Next;
            tail.Next = head;
            return;
        }
        Process temp = head;
        while (temp.Next != head && temp.Next.ProcessID != id)
        {
            temp = temp.Next;
        }
        if (temp.Next.ProcessID == id)
        {
            temp.Next = temp.Next.Next;
            if (temp.Next == head) tail = temp;
        }
    }
}
