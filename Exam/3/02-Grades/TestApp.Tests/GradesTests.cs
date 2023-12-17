using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> gradesDict = new()
        {
            { "Ana", 5 },
            { "Ivan", 2 },
            { "Yasmina", 4 },
            { "Hordu", 6 },            
            { "Viktoria", 3 },
            { "Marin", 8 },
        };
        string expected = $"Marin with average grade 8.00{Environment.NewLine}Hordu with average grade 6.00{Environment.NewLine}Ana with average grade 5.00";

        // Act 
        string result = Grades.GetBestStudents(gradesDict);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> gradesDict = new();
        string expected = string.Empty;

        // Act 
        string result = Grades.GetBestStudents(gradesDict);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> gradesDict = new()
        {
            { "Ana", 5 },
            { "Ivan", 2 },
        };
        string expected = $"Ana with average grade 5.00{Environment.NewLine}Ivan with average grade 2.00";

        // Act 
        string result = Grades.GetBestStudents(gradesDict);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> gradesDict = new()
        {
            { "Ivan", 2 },
            { "Yasmina", 4 },
            { "Hordu", 5 },
            { "Viktoria", 3 },
            { "Marin", 5 },
            { "Ana", 5 },
        };
        string expected = $"Ana with average grade 5.00{Environment.NewLine}Hordu with average grade 5.00{Environment.NewLine}Marin with average grade 5.00";

        // Act 
        string result = Grades.GetBestStudents(gradesDict);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
