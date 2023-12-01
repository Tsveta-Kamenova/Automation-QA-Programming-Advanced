using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace TestApp.UnitTests;

public class ArticleTests
{
    public Article _article;

    [SetUp]
    public void Setup()
    {
        this._article = new Article();
    }


    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articles = 
        { 
            "Article Content Author", 
            "Article2 Content2 Author2", 
            "Article3 Content3 Author3" 
        };

        // Act
         Article result = this._article.AddArticles(articles);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));

        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[0].Content, Is.EqualTo("Content"));
        Assert.That(result.ArticleList[0].Author, Is.EqualTo("Author"));
        Assert.That(result.ArticleList[1].Title, Is.EqualTo("Article2"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[1].Author, Is.EqualTo("Author2"));
        Assert.That(result.ArticleList[2].Title, Is.EqualTo("Article3"));
        Assert.That(result.ArticleList[2].Content, Is.EqualTo("Content3"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        Article inputArticle = new Article()
        {
            ArticleList = new List<Article>()
            {
                new Article()
                {
                    Author = "Flower",
                    Content = "Content first",
                    Title = "QA Pros"
                },
                new Article()
                {
                    Author = "ASCII Flower",
                    Content = "New Content",
                    Title = "Updated QA Pros"
                },
            }

        };

        string expected = $"QA Pros - Content first: Flower{Environment.NewLine}Updated QA Pros - New Content: ASCII Flower";

        // Act
        string actual = this._article.GetArticleList(inputArticle, "title");

        //// Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        Article inputArticle = new Article()
        {
            ArticleList = new List<Article>()
            {
                new Article()
                {
                    Author = "Flower",
                    Content = "Content first",
                    Title = "QA Pros"
                },
                new Article()
                {
                    Author = "ASCII Flower",
                    Content = "New Content",
                    Title = "Updated QA Pros"
                },
            }

        };

        // Act
        string actual = this._article.GetArticleList(inputArticle, "speed");

        //// Assert
        Assert.That(actual, Is.Empty);
    }


    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenArticleHasNoArticlesInItsList()
    {
        // Arrange
        Article inputArticle = new Article()
        {
            ArticleList = new()
        };

        // Act
        string actual = this._article.GetArticleList(inputArticle, "title");

        //// Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByAuthor()
    {
        // Arrange
        Article inputArticle = new Article()
        {
            ArticleList = new List<Article>()
            {
                new Article()
                {
                    Author = "Flower",
                    Content = "Content first",
                    Title = "QA Pros"
                },
                new Article()
                {
                    Author = "ASCII Flower",
                    Content = "New Content",
                    Title = "Updated QA Pros"
                },
            }

        };

        string expected = $"Updated QA Pros - New Content: ASCII Flower{Environment.NewLine}QA Pros - Content first: Flower";

        // Act
        string actual = this._article.GetArticleList(inputArticle, "author");

        //// Assert
        Assert.That(actual, Is.EqualTo(expected));
    }


    [Test]
    public void Test_GetArticleList_SortsArticlesByContent()
    {
        // Arrange
        Article inputArticle = new Article()
        {
            ArticleList = new List<Article>()
            {
                new Article()
                {
                    Author = "Flower",
                    Content = "Content first",
                    Title = "QA Pros"
                },
                new Article()
                {
                    Author = "ASCII Flower",
                    Content = "New Content",
                    Title = "Updated QA Pros"
                },
            }

        };

        string expected = $"QA Pros - Content first: Flower{Environment.NewLine}Updated QA Pros - New Content: ASCII Flower";

        // Act
        string actual = this._article.GetArticleList(inputArticle, "content");

        //// Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
