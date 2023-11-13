using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("cat", 2, "cAtcAt")]
    [TestCase("qwerty", 3, "qWeRtYqWeRtYqWeRtY")]
    [TestCase("t", 5, "ttttt")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // TODO: finish the test
    }
}
