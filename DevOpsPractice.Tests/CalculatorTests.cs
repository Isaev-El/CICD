using DevOpsPractice.Api.Services;

namespace DevOpsPractice.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        var service = new CalculatorService();

        var result = service.Add(2, 3);

        Assert.Equal(10, result);
    }
}