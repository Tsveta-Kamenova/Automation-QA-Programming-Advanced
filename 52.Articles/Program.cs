namespace _52.Articles
{
    internal class Program
    {

        public class Article
        {
            public Article(string title, string content, string author)
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


        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(", ").ToArray();

            string content = firstInput[0];
            string title = firstInput[1];
            string author = firstInput[2];

            Article article = new Article(content, title, author);

            int numberOfChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfChanges; i++)
            {
                string[] secondInput = Console.ReadLine().Split(": ").ToArray();
                
                string command = secondInput[0];
                string fieldToChange = secondInput[1];

                if (command == "Edit")
                {
                    article.Edit(fieldToChange);
                }
                if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(fieldToChange);
                }
                if(command == "Rename")
                {
                    article.Rename(fieldToChange);
                }
            }

            article.ToString(article.Title, article.Content, article.Author);
        }
    }
}