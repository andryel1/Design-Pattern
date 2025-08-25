using Prototype.Interface;
using Prototype.Modelo.Enum;

namespace Prototype.Modelo;

public class Contrato : IClonagem
{
    public string Titulo { get; set; } = string.Empty;
    public string Conteudo { get; set; } = string.Empty;
    public Tipo Tipo { get; set; }
    public Contratante Contratante { get; set; } = new Contratante();
    public List<string> Clausulas { get; set; } = new List<string>();

    public Contrato()
    {
    }

    public Contrato ClonagemRasa()
    {
        return (Contrato)this.MemberwiseClone();
    }

    public Contrato ClonagemProfunda()
    {
        return new Contrato
        {
            Titulo = Titulo,
            Conteudo = Conteudo,
            Tipo = Tipo,
            Contratante = new Contratante
            (
                Contratante.Nome,
                Contratante.Cnpj,
                Contratante.Endereco
            ),
            Clausulas = new List<string>(Clausulas)
        };
    }
}
