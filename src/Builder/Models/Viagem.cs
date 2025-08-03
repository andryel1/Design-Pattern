namespace Builder.Models;

public class Viagem
{
    public string? Destino {get; set;} 
    public string? TipoAlimentacao {get; set;} 
    public bool TransporteIncluso {get; set;}
    public bool Hospedagem {get; set;}
    public bool PassageiroGuiados {get; set;}
    public int Dias {get; set;}

    public override string ToString()
    {
        return $"Destino: {Destino}, Transporte Incluso: {TransporteIncluso}, Hospedagem: {Hospedagem}, Passageiro Guiados: {PassageiroGuiados}, Dias: {Dias}, Tipo Alimentacao: {TipoAlimentacao}";
    }
}