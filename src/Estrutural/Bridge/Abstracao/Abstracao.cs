using Estrutural.Bridge.Interface;

namespace Estrutural.Bridge.Abstracao;

public abstract class Abstracao(IRelatorio relatorio)
{
    protected readonly IRelatorio _relatorio = relatorio;

    public abstract void GerarRelatorio();
}