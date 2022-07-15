using Xunit;

namespace UnitTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //arrange
        var x = 56;
        var y = 32;
        var expected = 88;
        //act
        var actual = x + y;
        //assert
        Assert.Equal(expected, actual);
    }
}