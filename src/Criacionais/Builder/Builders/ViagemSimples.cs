using Builder.Interface;
using Builder.Models;

namespace Builder.Builders{

public class ViagemSimples : IViagem
{
    private Viagem _viagem = new Viagem();

    public void Reset() => _viagem = new Viagem();

    public void Destino(string destino) => _viagem.Destino = destino;

    public void TransporteIncluso () => _viagem.TransporteIncluso = true;

    public void Hospedagem() =>_viagem.Hospedagem = false;

    public void TipoAlimentacao(string alimento) => _viagem.TipoAlimentacao = alimento;
    
    public void PassageiroGuiados() => _viagem.PassageiroGuiados = false;

    public void Dias(int dias) => _viagem.Dias = dias; 

    public Viagem GetViagem() => _viagem;
}
}