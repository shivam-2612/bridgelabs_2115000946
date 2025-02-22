using System;
using System.Threading;
using NUnit.Framework;

public class TaskRunner
{
    public void LongTask() => Thread.Sleep(3000);
}

[TestFixture]
public class TaskRunnerTests
{
    private TaskRunner runner;

    [SetUp]
    public void Setup() => runner = new TaskRunner();

    [Test, Timeout(2000)]
    public void LongTaskTest() => runner.LongTask();
}
