namespace Criacionais.Bridge.Exportadores;

public class ExportadorPdf : IRelatorio
{
    public void Exportar(string conteudo)
    {
        Console.WriteLine($"Criando o {conteudo}");
    }
}