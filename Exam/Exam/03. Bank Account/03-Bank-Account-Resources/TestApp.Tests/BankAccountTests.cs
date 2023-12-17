using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestApp.Tests;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    BankAccount _bankAccount = null;

    ////[SetUp]
    ////public void Setup()
    ////{
    ////    this._bankAccount = new();
    ////}

    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double initBalance = 324.5;

        // Act 
        this._bankAccount = new(initBalance);
        double expected = 324.5;
        double result = this._bankAccount.Balance;

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double initBalance = 324.5;
        double amount = 10;

        // Act 
        this._bankAccount = new(initBalance);
        this._bankAccount.Deposit(amount);
        double expected = 334.5;
        double result = this._bankAccount.Balance;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initBalance = 324.5;
        this._bankAccount = new(initBalance);
        double amount = -110;

        // Act & Assert
        Assert.That(() => _bankAccount.Deposit(amount), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double initBalance = 324.5;
        double amount = 10;

        // Act 
        this._bankAccount = new(initBalance);
        this._bankAccount.Withdraw(amount);
        double expected = 314.5;
        double result = this._bankAccount.Balance;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initBalance = 324.5;
        this._bankAccount = new(initBalance);
        double amount = -110;

        // Act & Assert
        Assert.That(() => _bankAccount.Withdraw(amount), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double initBalance = 324.5;
        this._bankAccount = new(initBalance);
        double amount = 1010;

        // Act & Assert
        Assert.That(() => _bankAccount.Withdraw(amount), Throws.ArgumentException);
    }
}
