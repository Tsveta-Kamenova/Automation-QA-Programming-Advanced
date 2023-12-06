using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "hello";
        string expected = "olleh";

        // Act
        string result = this._exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal expected = 80;
        decimal totalPrice = 100;
        decimal discount = 20;

        //Act
        decimal result = this._exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100;
        decimal discount = -20;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int expected = 5;
        int[] input = { 2, 3, 4, 5 };
        int index = 3;

        // Act
        int result = this._exceptions.IndexOutOfRangeGetElement(input, index);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 2, 3, 4, 5 };
        int index = 20;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 10;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        string expected = "User logged in.";
        bool input = true;

        // Act
        string result = this._exceptions.InvalidOperationPerformSecureOperation(input);

        //Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool input = false;

        // Act & Assert
        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(input), Throws.InvalidOperationException);
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string input = "456";
        int expected = 456;

        // Act
        int result = this._exceptions.FormatExceptionParseInt(input);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        string input = "asd";

        // Act & Assert
        Assert.That(() => this._exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        string key = "asd";
        int value = 1;
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary[key] = value;
        int expected = 1;

        // Act
        int result = this._exceptions.KeyNotFoundFindValueByKey(dictionary, "asd");

        //Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        string key = "qwerty";
        int value = 1;
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary[key] = value;

        // Act & Assert
        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(dictionary, "asd"), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_PositiveNumbers_ReturnsSum()
    {
        // Arrange 
        int a = 5;
        int b = 200;
        int expected = 205;

        // Act 
        int result = this._exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_MixedSignNumbers_ReturnsSum()
    {
        // Arrange 
        int a = -5;
        int b = 200;
        int expected = 195;

        // Act 
        int result = this._exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange 
        int a = int.MaxValue;
        int b = int.MaxValue;

        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange 
        int a = int.MinValue;
        int b = int.MinValue;

        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        int dividend = 100;
        int divisor = 50;
        int expected = 2;

        // Act
        int result = this._exceptions.DivideByZeroDivideNumbers(dividend, divisor);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int dividend = 100;
        int divisor = 0;

        // Act & Assert
        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(dividend, divisor), Throws.InstanceOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] collectionInput = { 1, 2, 3, 4, 5 };
        int indexInput = 3;
        int expected = 15;

        // Act
        int result = this._exceptions.SumCollectionElements(collectionInput, indexInput);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[] collectionInput = null;
        int indexInput = 3;

        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collectionInput, indexInput), Throws.ArgumentNullException);

    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] collectionInput = { 1, 2, 3, 4, 5 };
        int indexInput = 10;

        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collectionInput, indexInput), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_SumCollectionElements_IndexIsNegative_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] collectionInput = { 1, 2, 3, 4, 5 };
        int indexInput = -2;

        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collectionInput, indexInput), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_SumCollectionElements_IndexIsCollectionLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] collectionInput = { 1, 2, 3, 4, 5 };
        int indexInput = 5;

        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collectionInput, indexInput), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        //Dictionary<string, string> dictionary = new Dictionary<string, string>();
        //string key = "key";
        //string value = "1";
        //dictionary[key] = value;
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            ["key1"] = "1",
            ["key2"] = "2",
            ["key3"] = "3",
            ["key4"] = "4"
        };
        int expected = 2;

        // Act
        int result = this._exceptions.GetElementAsNumber(dictionary, "key2");

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        //Dictionary<string, string> dictionary = new Dictionary<string, string>();
        //string key = "key";
        //string value = "1";
        //dictionary[key] = value;
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            ["key1"] = "1",
            ["key2"] = "2",
            ["key3"] = "3",
            ["key4"] = "4"
        };

        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(dictionary, "newkey"), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        string key = "key";
        string value = "value";
        dictionary[key] = value;

        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(dictionary, "key"), Throws.InstanceOf<FormatException>());
    }
}
