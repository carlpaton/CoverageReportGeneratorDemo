namespace Cover.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var result = SumCode.Sum(1, 3);
        Assert.Equal(4, result);
    }
}