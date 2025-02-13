using System;
using System.Collections.Generic;

public class CustomHashMap<K, V>
{
    private class Node
    {
        public K Key;
        public V Value;
        public Node Next;
        public Node(K key, V value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    private readonly int _size;
    private readonly LinkedList<Node>[] _buckets;

    public CustomHashMap(int size = 100)
    {
        _size = size;
        _buckets = new LinkedList<Node>[size];
    }

    private int GetHash(K key)
    {
        return Math.Abs(key.GetHashCode()) % _size;
    }

    public void Insert(K key, V value)
    {
        int index = GetHash(key);
        if (_buckets[index] == null)
            _buckets[index] = new LinkedList<Node>();

        foreach (var node in _buckets[index])
        {
            if (node.Key.Equals(key))
            {
                node.Value = value;
                return;
            }
        }

        _buckets[index].AddLast(new Node(key, value));
    }

    public bool Delete(K key)
    {
        int index = GetHash(key);
        if (_buckets[index] == null)
            return false;

        var current = _buckets[index].First;
        while (current != null)
        {
            if (current.Value.Key.Equals(key))
            {
                _buckets[index].Remove(current);
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public V Get(K key)
    {
        int index = GetHash(key);
        if (_buckets[index] != null)
        {
            foreach (var node in _buckets[index])
            {
                if (node.Key.Equals(key))
                    return node.Value;
            }
        }
        throw new KeyNotFoundException("Key not found");
    }

    public bool ContainsKey(K key)
    {
        int index = GetHash(key);
        if (_buckets[index] != null)
        {
            foreach (var node in _buckets[index])
            {
                if (node.Key.Equals(key))
                    return true;
            }
        }
        return false;
    }
}

class Program
{
    static void Main()
    {
        CustomHashMap<int, string> map = new CustomHashMap<int, string>();

        map.Insert(1, "One");
        map.Insert(2, "Two");
        map.Insert(3, "Three");

        Console.WriteLine(map.Get(2));

        map.Delete(2);
        Console.WriteLine(map.ContainsKey(2));
    }
}
