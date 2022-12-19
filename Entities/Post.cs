using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Resolvido_2_Enumeracao_e_Composicao.Entities
{
    internal class Post
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ComentariosEmTexto { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public Post()
        {
        }

        public Post(DateTime date, string title, string content, int likes)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
        public void TransformarComentariosEmTexto()
        {
            foreach (Comment comment in Comments)
            {
                ComentariosEmTexto += comment + "\n";
            }
        }

        public override string ToString()
        {
            return $"\n{Title}\n{Likes} likes - {Date}\n{Content}\nComments:{ComentariosEmTexto}";
        }
    }
}
