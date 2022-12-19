using Exercicio_Resolvido_2_Enumeracao_e_Composicao.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio_Resolvido_2_Enumeracao_e_Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Post> posts = new List<Post>();
            int numberofposts, likes, numberofcomments;
            string title, content, answer;
            Console.WriteLine("How many posts would you like to do?");
            numberofposts = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberofposts; i++)
            {
                Console.WriteLine($"Post #{i + 1}");
                Console.Write("Moment(DD/MM/YYYY HH:MM:SS): ");
                DateTime moment = DateTime.Parse(Console.ReadLine());
                Console.Write("Title: ");
                title = Console.ReadLine();
                Console.Write("Content: ");
                content = Console.ReadLine();
                Console.WriteLine("How many likes has this post?");
                likes = int.Parse(Console.ReadLine());
                Console.WriteLine("Would you like to comment?(yes/no)");
                answer = Console.ReadLine();
                Post post = new Post(moment, title, content, likes);
                if (answer == "yes")
                {
                    Console.WriteLine("How many times?");
                    numberofcomments = int.Parse(Console.ReadLine());
                    for (int j = 0; j < numberofcomments; j++)
                    {
                        Console.WriteLine($"Comment #{j+1}");
                        Comment comment = new Comment(Console.ReadLine());
                        post.AddComment(comment);
                    }
                }
                posts.Add(post);
            }
            foreach (Post item in posts)
            {
                Console.WriteLine(item);
                foreach (Comment comment in item.Comments)
                {
                    Console.WriteLine(comment);
                }
            }
        }
    }
}
