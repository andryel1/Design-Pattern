using Builder.Interface;
using Builder.Models;

namespace Builder.Builders{

public class ViagemLuxo : IViagem
{
    private Viagem _viagem = new Viagem();

    public void Reset() => _viagem = new Viagem();

    public void Destino(string destino) => _viagem.Destino = destino;

    public void TipoAlimentacao(string alimentacao) => _viagem.TipoAlimentacao = alimentacao;

    public void TransporteIncluso() => _viagem.TransporteIncluso = true;

    public void Hospedagem() => _viagem.Hospedagem = true;
    
    public void PassageiroGuiados() => _viagem.PassageiroGuiados = true;

    public void Dias(int dias) => _viagem.Dias = dias;

    public Viagem GetViagem() => _viagem;
}
}