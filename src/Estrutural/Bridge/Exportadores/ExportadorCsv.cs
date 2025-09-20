namespace Criacionais.Bridge.Exportadores;

public class ExportadorCsv : IRelatorio
{
    public void Exportar(string conteudo)
    {
        Console.WriteLine($"Criando o {conteudo}");
    }
}