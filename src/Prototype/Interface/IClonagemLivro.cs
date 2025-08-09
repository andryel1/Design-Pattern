using Prototype.Modelo;

namespace Prototype.Interface;

public interface IClonagemLivro
{
    Livro CloneRaso();
    Livro CloneProfundo();
}