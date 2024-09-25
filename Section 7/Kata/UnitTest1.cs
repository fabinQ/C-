using System.Runtime.CompilerServices;

namespace Kata;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SplitTest()
    {
        string testString = "this is a test";
        List<string> result = Kata.Split(testString, ' ');

        Assert.That(result[3], Is.EqualTo("test"));
        Assert.AreEqual("a", result[2]);
        Assert.AreEqual("is", result[1]);
        Assert.AreEqual("this", result[0]);
    }
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("world! hello", Kata.ReverseWords("hello world!"));
        Assert.AreEqual("this like speak doesn't yoda", Kata.ReverseWords("yoda doesn't speak like this"));
        Assert.AreEqual("foobar", Kata.ReverseWords("foobar"));
        Assert.AreEqual("kata editor", Kata.ReverseWords("editor kata"));
        Assert.AreEqual("boat your row row row", Kata.ReverseWords("row row row your boat"));
        Assert.AreEqual("", Kata.ReverseWords(""));
    }
}