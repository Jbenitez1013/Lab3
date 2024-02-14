
using MinLib;
using Xunit;

namespace MinLibTest;
public class UnitTest1
{
    [Fact]
    
    public void TestminOf4and5() {

        double a = 4, b=5; //arrange
        double expected = 4;

        double actual = Min.Minof2(a,b); // act

        Assert.Equal(expected,actual); // assert

    }

       [Fact]
    
    public void TestminOf10and6() {

        double a = 10, b=6; //arrange
        double expected = 6;

        double actual = Min.Minof2(a,b); // act

        Assert.Equal(expected,actual); // assert

    }   



}