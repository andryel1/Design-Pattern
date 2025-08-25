namespace Prototype.Modelo;

public class Contratante
{
    public string Nome { get; set; } = null!;
    public string Cnpj { get; set; } = null!;
    public string Endereco { get; set; } = null!;

    public Contratante() {}
    public Contratante(string nome, string cnpj, string endereco)
    {
        Nome = nome;
        Cnpj = cnpj;
        Endereco = endereco;
    }
}