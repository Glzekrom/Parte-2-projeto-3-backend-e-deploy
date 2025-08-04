using WebServiceLivros.Models;

namespace WebServiceLivros.Services
{
    public class LivroService
    {
        private static List<Livro> livros = new List<Livro>();
        private static int proximoId = 1;

        public List<Livro> ObterTodos() => livros;

        public Livro? ObterPorId(int id) => livros.FirstOrDefault(l => l.Id == id);

        public Livro Criar(Livro livro)
        {
            livro.Id = proximoId++;
            livros.Add(livro);
            return livro;
        }

        public bool Atualizar(int id, Livro livroAtualizado)
        {
            var livro = ObterPorId(id);
            if (livro == null) return false;

            livro.Titulo = livroAtualizado.Titulo;
            livro.Autor = livroAtualizado.Autor;
            livro.Editora = livroAtualizado.Editora;
            livro.Genero = livroAtualizado.Genero;
            return true;
        }

        public bool Remover(int id)
        {
            var livro = ObterPorId(id);
            if (livro == null) return false;
            livros.Remove(livro);
            return true;
        }
    }
}
