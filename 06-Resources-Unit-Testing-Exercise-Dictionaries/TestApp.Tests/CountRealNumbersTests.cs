using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        //int[] input = new int[0];
        int[] input = Array.Empty<int>();
        //int[] input = { };

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { 5 };

        StringBuilder sb = new();
        sb.AppendLine("5 -> 1");


        string expectedResult = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { 2, 1, 1, 4, 4, 4, 4, 1 };

        StringBuilder sb = new();
        sb.AppendLine("1 -> 3");
        sb.AppendLine("2 -> 1");
        sb.AppendLine("4 -> 4");
    
        string expectedResult = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { 3, 2, 1, -2, 1, -4, -4, -4 };


        StringBuilder sb = new();
        sb.AppendLine("-4 -> 3");
        sb.AppendLine("-2 -> 1");
        sb.AppendLine("1 -> 2");
        sb.AppendLine("2 -> 1");
        sb.AppendLine("3 -> 1");


        string expectedResult = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { 0, -2, 1, 4, 0, 0 };


        StringBuilder sb = new();
        sb.AppendLine("-2 -> 1");
        sb.AppendLine("0 -> 3");
        sb.AppendLine("1 -> 1");
        sb.AppendLine("4 -> 1");

        string expectedResult = sb.ToString().Trim();
        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithSingleZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { 0, 0, 0, 0, 0};


        StringBuilder sb = new();
        sb.AppendLine("0 -> 5");


        string expectedResult = sb.ToString().Trim();
        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithSingleBigNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { 509843532 };

        StringBuilder sb = new();
        sb.AppendLine("509843532 -> 1");


        string expectedResult = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
