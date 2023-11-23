using System;

[TestFixture]
public class ConverterTests
{
    [Test]
    public void Do_PositiveNumber_ReturnsIntegerPart()
    {
        float input = 42.3f;
        int result = Converter.Do(input);
        Assert.AreEqual(42, result);
    }

    [Test]
    public void Do_Zero_Returns1000()
    {
        float input = 0f;
        int result = Converter.Do(input);
        Assert.AreEqual(1000, result);
    }

    [Test]
    public void Do_NegativeOne_ThrowsArgumentException()
    {
        float input = -1f;
        Assert.Throws<ArgumentException>(() => Converter.Do(input));
    }

    [Test]
    public void Do_NegativeNumber_ReturnsIntegerPartMinus5()
    {
        float input = -94.5f;
        int result = Converter.Do(input);
        Assert.AreEqual(-99, result);
    }

    [Test]
    public void Do_OtherCases_ReturnsMinus2000()
    {
        float input = 65.7f;
        int result = Converter.Do(input);
        Assert.AreEqual(-2000, result);
    }
}