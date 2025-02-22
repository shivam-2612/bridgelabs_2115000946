using System;
using System.Collections.Generic;
using NUnit.Framework;

public class ListManager
{
    public void Add(List<int> list, int item) => list.Add(item);
    public void Remove(List<int> list, int item) => list.Remove(item);
    public int Size(List<int> list) => list.Count;
}

[TestFixture]
public class ListManagerTests
{
    private ListManager manager;
    private List<int> list;

    [SetUp]
    public void Setup()
    {
        manager = new ListManager();
        list = new List<int>();
    }

    [Test]
    public void Add() 
    {
        manager.Add(list, 5);
        Assert.Contains(5, list);
    }

    [Test]
    public void Remove()
    {
        list.Add(10);
        manager.Remove(list, 10);
        Assert.IsFalse(list.Contains(10));
    }

    [Test]
    public void Size()
    {
        manager.Add(list, 1);
        manager.Add(list, 2);
        Assert.AreEqual(2, manager.Size(list));
    }
}
