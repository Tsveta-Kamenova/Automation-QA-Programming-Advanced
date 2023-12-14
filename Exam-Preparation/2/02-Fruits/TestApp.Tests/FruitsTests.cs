using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruitsDict = new()
        {
            { "apple" , 5 },
            { "banana" , 6 },
        };

        string fruitName = "apple";
        int expected = 5;

        // Act 
        int result = Fruits.GetFruitQuantity(fruitsDict,fruitName);


        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDict = new()
        {
            { "apple" , 5 },
            { "banana" , 6 },
        };

        string fruitName = "orange";
        int expected = 0;

        // Act 
        int result = Fruits.GetFruitQuantity(fruitsDict, fruitName);


        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDict = new();

        string fruitName = "orange";
        int expected = 0;

        // Act 
        int result = Fruits.GetFruitQuantity(fruitsDict, fruitName);


        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDict = null;

        string fruitName = "banana";
        int expected = 0;

        // Act 
        int result = Fruits.GetFruitQuantity(fruitsDict, fruitName);


        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDict = new()
        {
            { "apple" , 0 },
            { "banana" , 0 },
        };

        string fruitName = null;
        int expected = 0;

        // Act 
        int result = Fruits.GetFruitQuantity(fruitsDict, fruitName);


        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }
}
