using EndProject.Console;
    
namespace EndProject.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var one = new One();
        one.MethodAccessException();
        Assert.Pass();
    }
}