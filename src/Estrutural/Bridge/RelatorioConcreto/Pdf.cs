using Estrutural.Bridge.Abstracao;

namespace Estrutural.Bridge.RelatorioConcreto;

public class Pdf : Abstracao
{
    protected Pdf(IRelatorio relatorio) : base(relatorio) { }

    public override void GerarRelatorio()
    {
        string conteudo = "Relatório de Funcionários";
        Console.WriteLine($"Gerando {conteudo}");
        exportador.Exportar(conteudo);
    }
}