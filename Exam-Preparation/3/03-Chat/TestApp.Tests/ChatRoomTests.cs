using System;
using NUnit.Framework;
using TestApp.Chat;
namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        // Arrange
        string sender = "Ivan";
        string message = "Hi";
        this._chatRoom.SendMessage(sender, message);

        // Act
        string result = this._chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain("Ivan: Hi"));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Act
        string result = this._chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        // Arrange
        string sender = "Ivan";
        string message = "Hi";
        this._chatRoom.SendMessage(sender, message);
        string sender1 = "Katerina";
        string message1 = "Bye";
        this._chatRoom.SendMessage(sender1, message1);
        string sender2 = "Hack";
        string message2 = "so what";
        this._chatRoom.SendMessage(sender2, message2);

        string expected = $"Chat Room Messages:{Environment.NewLine}{sender}: {message} - Sent at {DateTime.Now.Date.ToString("d")}{Environment.NewLine}" +
            $"{sender1}: {message1} - Sent at {DateTime.Now.Date.ToString("d")}{Environment.NewLine}" +
            $"{sender2}: {message2} - Sent at {DateTime.Now.Date.ToString("d")}";

        // Act
        string result = this._chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain("Ivan: Hi"));
        Assert.That(result, Does.Contain("Katerina: Bye"));
        Assert.That(result, Does.Contain("Hack: so what"));
        Assert.That(result, Is.EqualTo(expected));
    }
}
