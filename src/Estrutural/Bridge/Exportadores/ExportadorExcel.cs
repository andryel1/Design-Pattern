namespace Criacionais.Bridge.Exportadores;

public class ExportadorExcel : IRelatorio
{
    public void Exportar(string conteudo)
    {
        Console.WriteLine($"Criando o {conteudo}");
    }
}