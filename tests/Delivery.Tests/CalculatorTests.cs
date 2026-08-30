using Delivery.Api;

namespace Delivery.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectResult()
    {
        var result = Calculator.Add(2, 3);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Multiply_ReturnsCorrectResult()
    {
        var result = Calculator.Multiply(4, 5);

        Assert.Equal(20, result);
    }

    [Fact]
    public void Add_WithNegativeNumber_ReturnsCorrectResult()
    {
        var result = Calculator.Add(-5, 3);

        Assert.Equal(-2, result);
    }
}
