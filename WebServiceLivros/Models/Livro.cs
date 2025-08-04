using System.ComponentModel.DataAnnotations;
namespace WebServiceLivros.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Editora { get; set; }
        public string? Genero { get; set; }
    }
}
