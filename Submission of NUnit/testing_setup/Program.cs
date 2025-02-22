using System;
using NUnit.Framework;

public class DatabaseConnection
{
    public bool IsConnected { get; private set; }

    public void Connect() => IsConnected = true;
    public void Disconnect() => IsConnected = false;
}

[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection db;

    [SetUp]
    public void Setup()
    {
        db = new DatabaseConnection();
        db.Connect();
    }

    [TearDown]
    public void Teardown() => db.Disconnect();

    [Test]
    public void ConnectTest() => Assert.IsTrue(db.IsConnected);

    [Test]
    public void DisconnectTest()
    {
        db.Disconnect();
        Assert.IsFalse(db.IsConnected);
    }
}
