using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _52.Articles
{
    public class Article
    {
        public Article(string title , string content , string author )
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void ToString(string title, string content, string author)
        {
            Console.WriteLine($"{title} - {content}: {author}");
        }
    }
}
