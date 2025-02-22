using System;
using System.IO;
using NUnit.Framework;

public class FileProcessor
{
    public void WriteToFile(string filename, string content) => File.WriteAllText(filename, content);
    public string ReadFromFile(string filename) => File.ReadAllText(filename);
}

[TestFixture]
public class FileProcessorTests
{
    private FileProcessor processor;
    private string filePath = "testfile.txt";

    [SetUp]
    public void Setup() => processor = new FileProcessor();

    [Test]
    public void WriteReadTest()
    {
        processor.WriteToFile(filePath, "Hello");
        Assert.AreEqual("Hello", processor.ReadFromFile(filePath));
    }

    [Test]
    public void FileExistsTest()
    {
        processor.WriteToFile(filePath, "Test");
        Assert.IsTrue(File.Exists(filePath));
    }

    [Test]
    public void ReadNonExistentFile() => Assert.Throws<FileNotFoundException>(() => processor.ReadFromFile("nofile.txt"));
}
