using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictionary = new();
        Dictionary<string, int> secondDictionary = new();

        // Act 
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);


        // Assert
        Assert.That(result.Count, Is.EqualTo(0));
        //Assert.That(result, Has.Count.EqualTo(0));
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictionary = new();
        Dictionary<string, int> secondDictionary = new()
        {
            { "one" , 1 },
            { "two" , 2 },
            { "three" , 3 },
        };

        // Act 
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);


        // Assert
        //Assert.That(result.Count, Is.EqualTo(0));
        //Assert.That(result, Has.Count.EqualTo(0));
        Assert.IsTrue(result.Count == 0);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictionary = new()
        {
            { "five" , 5 },
            { "six" , 6 },
            { "seven" , 7 },
        };
        Dictionary<string, int> secondDictionary = new()
        {
            { "one" , 1 },
            { "two" , 2 },
            { "three" , 3 },
        };

        // Act 
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);


        // Assert
        //Assert.That(result.Count, Is.EqualTo(0));
        //Assert.That(result, Has.Count.EqualTo(0));
        Assert.IsTrue(result.Count == 0);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictionary = new()
        {
            { "five" , 5 },
            { "six" , 6 },
            { "seven" , 7 },
            { "one" , 1 },
            { "two" , 2 },
        };
        Dictionary<string, int> secondDictionary = new()
        {
            { "one" , 1 },
            { "two" , 2 },
            { "three" , 3 },
            { "seven" , 7 },
        };

        Dictionary<string, int> expectedDictionary = new()
        {
            { "one" , 1 },
            { "two" , 2 },
            { "seven" , 7 },
        };

        // Act 
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);


        // Assert
        Assert.That(expectedDictionary, Is.EqualTo(result));
        Assert.IsTrue(result.Count == 3);
        Assert.IsTrue(result.ContainsKey("one"));
        Assert.IsTrue(result.ContainsKey("seven"));
        Assert.IsFalse(result.ContainsKey("three"));
        Assert.AreEqual(1, result["one"]);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictionary = new()
        {
            { "five" , 55 },
            { "six" , 66 },
            { "seven" , 77 },
            { "one" , 11 },
            { "two" , 22 },
        };
        Dictionary<string, int> secondDictionary = new()
        {
            { "one" , 1 },
            { "two" , 2 },
            { "three" , 3 },
            { "seven" , 7 },
        };

        Dictionary<string, int> expectedDictionary = new();

        // Act 
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);


        // Assert
        Assert.That(expectedDictionary, Is.EqualTo(result));
        Assert.IsTrue(result.Count == 0);
    }
}
