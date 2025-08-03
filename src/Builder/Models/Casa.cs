namespace Builders.Models
{

public class Casa
{
    public string EstruturaDaCasa { get; set; } = null!;
    public bool TemGaragem { get; set; }
    public bool TemPiscina { get; set; }
    public bool TemJardim { get; set; }
    public int Andares { get; set; }
    public string Cor { get; set; } = null!;
    public override string ToString()
    {
        return $"Estrutura: {EstruturaDaCasa}, Garagem: {TemGaragem}, Piscina: {TemPiscina}, Jardim: {TemJardim}, Andares: {Andares}, Cor: {Cor}";
    }
}

}