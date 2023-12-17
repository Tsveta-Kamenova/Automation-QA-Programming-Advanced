using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string name = "Oil";
        double price = 12.5;
        int quantity = 2;

        // Act 
        _inventory.AddProduct(name, price, quantity);
        string expected = $"Product Inventory:{Environment.NewLine}{name} - Price: ${price:f2} - Quantity: {quantity}";
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.That(expected, Is.EqualTo(result));
     }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange

        // Act 
        string expected = $"Product Inventory:";
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        string name1 = "Oil";
        double price1 = 12.5;
        int quantity1 = 2;

        string name2 = "Bread";
        double price2 = 1.5;
        int quantity2 = 5;

        // Act 
        _inventory.AddProduct(name1, price1, quantity1);
        _inventory.AddProduct(name2, price2, quantity2);

        string expected = $"Product Inventory:{Environment.NewLine}{name1} - Price: ${price1:f2} - Quantity: {quantity1}{Environment.NewLine}" +
                            $"{name2} - Price: ${price2:f2} - Quantity: {quantity2}";
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange

        // Act 
        double result = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        string name1 = "Oil";
        double price1 = 12.5;
        int quantity1 = 2;

        string name2 = "Bread";
        double price2 = 1.5;
        int quantity2 = 5;

        // Act 
        _inventory.AddProduct(name1, price1, quantity1);
        _inventory.AddProduct(name2, price2, quantity2);

        double result = _inventory.CalculateTotalValue();
        double expected = price1 * quantity1 + price2 * quantity2;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
