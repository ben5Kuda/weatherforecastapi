namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test_ShouldPass()
    {
        Assert.Equal(10, 10);
    }
    
    [Fact]
    public void Test_ShouldFail()
    {
        Assert.NotEqual(10, 12);
    }
}