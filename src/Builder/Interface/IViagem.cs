using Builder.Models;

namespace Builder.Interface;

public interface IViagem
{
    void Reset();
    void Destino(string destino);
    void TransporteIncluso();
    void Hospedagem();
    void PassageiroGuiados();
    void Dias(int dias);
    void TipoAlimentacao(string alimento);
    Viagem GetViagem();
}