using System.Reflection.Metadata;
using _1._Xunit_Project;
namespace _1.Xunit_Project.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int a = 1;
        int b = 2;
        int expectedResult = 3;

        int result = Operation.Add(a, b);

        Assert.Equal(expectedResult, result);
    }
}