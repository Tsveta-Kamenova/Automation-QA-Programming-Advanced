using System;
using Microsoft.VisualBasic;
using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        string taskName = "Washing";
        DateTime taskDate = DateTime.Today;
        _toDoList.AddTask(taskName, taskDate);
        //string dateString = "12/31/2023";
        //DateTime taskDate = DateTime.Parse(dateString);


        // Act 
        string result = _toDoList.DisplayTasks();
        //string expected = $"To-Do List:{Environment.NewLine}[ ] {taskName} - Due: {taskDate.ToString("MM/dd/yyyy")}";

        // Assert
        Assert.That(result, Does.Contain($"[ ] {taskName} - Due: "));
        //Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string taskName = "task to complete";
        DateTime taskDate = DateTime.Today;
        _toDoList.AddTask(taskName, taskDate);
        _toDoList.CompleteTask(taskName);


        // Act 
        string result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("[✓] task to complete - Due: "));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        string taskName = "task to complete";

        // Act & Assert
        Assert.That(() => _toDoList.CompleteTask(taskName), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Act 
        string result = _toDoList.DisplayTasks();
        string expected = "To-Do List:";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        string taskName = "task to complete";
        DateTime taskDate = DateTime.Today;
        _toDoList.AddTask(taskName, taskDate);

        // Act 
        string result = _toDoList.DisplayTasks();
        string expected = $"To-Do List:{Environment.NewLine}[ ] {taskName} - Due: {taskDate.ToString("MM/dd/yyyy")}";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
