using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int number = 0;

        // Act 
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);
        Dictionary<int, int> expected = new Dictionary<int, int>();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int number = 7;

        // Act 
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            { 7, 1 },
        };

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = 1174566610;

        // Act 
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            { 0, 1 },
            { 1, 3 },
            { 6, 3 },
            { 5, 1 },
            { 4, 1 },            
            { 7, 1 },
        };

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = -36;

        // Act 
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            { 3, 1 },
            { 6, 1 },
        };

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
