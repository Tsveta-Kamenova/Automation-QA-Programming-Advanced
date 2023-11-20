using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = Array.Empty<string>();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] { "flower" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 6 letters:{Environment.NewLine}flower"));

    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] { "tree", "flower", "tree", "bush", "567890", "@#$;", "hedge", "calendula", "a", "a", "a", "", " "};

        StringBuilder sb = new();
        sb.AppendLine($"Plants with 0 letters:{Environment.NewLine}");
        sb.AppendLine($"Plants with 1 letters:{Environment.NewLine}a{Environment.NewLine}a{Environment.NewLine}a{Environment.NewLine} ");
        sb.AppendLine($"Plants with 4 letters:{Environment.NewLine}tree{Environment.NewLine}tree{Environment.NewLine}bush{Environment.NewLine}@#$;");
        sb.AppendLine($"Plants with 5 letters:{Environment.NewLine}hedge");
        sb.AppendLine($"Plants with 6 letters:{Environment.NewLine}flower{Environment.NewLine}567890");
        sb.AppendLine($"Plants with 9 letters:{Environment.NewLine}calendula");


        string expectedResult = sb.ToString().Trim();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[] { "TRee", "fLOwer", "treE", "bush", "hedge", "calenDUla", "a", "A", "a" };

        StringBuilder sb = new();
        sb.AppendLine($"Plants with 1 letters:{Environment.NewLine}a{Environment.NewLine}A{Environment.NewLine}a");
        sb.AppendLine($"Plants with 4 letters:{Environment.NewLine}TRee{Environment.NewLine}treE{Environment.NewLine}bush");
        sb.AppendLine($"Plants with 5 letters:{Environment.NewLine}hedge");
        sb.AppendLine($"Plants with 6 letters:{Environment.NewLine}fLOwer");
        sb.AppendLine($"Plants with 9 letters:{Environment.NewLine}calenDUla");

        string expectedResult = sb.ToString().Trim();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
