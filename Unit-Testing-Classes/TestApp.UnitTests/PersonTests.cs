﻿using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TestApp.UnitTests;

public class PersonTests
{
    private Person _person;

    [SetUp]
    public void SetUp()
    {
        this._person = new Person();
    }

    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };
        List<Person> expectedPeopleList = new()
        {
            new Person
            {
                Name = "Alice",
                Id = "A001",
                Age = 35,
            },
            new Person
            {
                Name = "Bob",
                Id = "B002",
                Age = 30,
            }

        };
        
        // Act
        List<Person> resultPeopleList = this._person.AddPeople(peopleData);

        // Assert
        Assert.That(resultPeopleList, Has.Count.EqualTo(2));
        for (int i = 0; i < resultPeopleList.Count; i++)
        {
            Assert.That(resultPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
            Assert.That(resultPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
            Assert.That(resultPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        }
    }

    [Test]
    public void Test_AddPeople_ReturnsEmptyList_WhenNoDataIsGiven()
    {
        // Arrange
        string[] peopleData = {  };

        // Act
        List<Person> resultPeopleList = this._person.AddPeople(peopleData);

        // Assert
        Assert.That(resultPeopleList, Has.Count.EqualTo(0));
    }



    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
        string expectedString = $"Bob with ID: B002 is 30 years old.{Environment.NewLine}Alice with ID: A001 is 35 years old.{Environment.NewLine}Ivan with ID: B2 is 50 years old.";
        List<Person> inputListPeople = new()
        {
            new Person
            {
                Name = "Alice",
                Id = "A001",
                Age = 35,
            },
            new Person
            {
                Name = "Bob",
                Id = "B002",
                Age = 30,
            },
            new Person
            {
                Name = "Ivan",
                Id = "B2",
                Age = 50,
            }

        };

        // Act
        string resultPeopleList = this._person.GetByAgeAscending(inputListPeople);

        // Assert
        Assert.That(resultPeopleList, Is.EqualTo(expectedString));

    }

    [Test]
    public void Test_GetByAgeAscending_ReturnsEmptyString_WhenGivenNoData()
    {
        // Arrange
        List<Person> inputListPeople = new List<Person>();

        // Act
        string actual = this._person.GetByAgeAscending(inputListPeople);

        // Assert
        Assert.That(actual, Is.Empty);

    }
}
