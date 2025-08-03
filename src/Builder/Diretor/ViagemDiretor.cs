using Builder.Interface;

namespace Builders.Diretor;

public class ViagemDiretor(IViagem builder)
{
private IViagem _builder = builder;

    public void Construir(string tipo)
{
_builder.Reset();
_builder.Destino("New York");
_builder.TransporteIncluso();

if(tipo == "Completo")
{
    _builder.PassageiroGuiados();
    _builder.Dias(7); 
    _builder.TipoAlimentacao("Completa"); 
    _builder.Hospedagem();
}
else if(tipo == "Padrao")
{
 _builder.Dias(7); 
 _builder.Hospedagem();
 _builder.TipoAlimentacao("Simples"); 
}
}
}