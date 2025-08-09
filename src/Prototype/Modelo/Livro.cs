using Prototype.Interface;

namespace Prototype.Modelo;

public class Livro : IClonagemLivro
{
    public string Titulo { get; set; } = null!;
    public string Autor { get; set; } = null!;
    public List<string> Capitulos = new List<string> { };

    public Livro() { }
    public Livro(string titulo, string autor, List<string> capitulos)
    {
        Titulo = titulo;
        Autor = autor;
        Capitulos = capitulos;
    }

    public Livro CloneRaso()
    {
        return (Livro)this.MemberwiseClone();
    }
    public Livro CloneProfundo()
    {
        return new Livro
        {
            Titulo = Titulo,
            Autor = Autor,

            Capitulos = new List<string>(Capitulos)
        };
    }
}