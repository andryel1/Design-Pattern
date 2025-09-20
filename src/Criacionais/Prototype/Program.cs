using Prototype.Modelo;
using Prototype.Modelo.Enum;

class Program
{
    static void Main()
    {
        var Contrato = new Contrato
        {
            Titulo = "Estágio",
            Conteudo = "Contratação",
            Tipo = Tipo.Trabalho,
            Contratante = new Contratante
            {
                Nome = "Felipe",
                Cnpj = "1111111111111",
                Endereco = "Rua de Berna"
            },
            Clausulas = new List<string> { "clausula 1 - Não pode ter dois" }
        };

        Console.WriteLine("Contrato original:");
        Console.WriteLine($"Título: {Contrato.Titulo}");
        Console.WriteLine($"Contratante: {Contrato.Contratante.Nome}");
        Console.WriteLine($"Cláusulas: {string.Join(", ", Contrato.Clausulas)}");

        var contratoRaso = Contrato.ClonagemRasa();
        contratoRaso.Contratante.Nome = "josé";

        var contratoProfundo = Contrato.ClonagemProfunda();
        

        Console.WriteLine("\nContrato clonado (rasa):");
        Console.WriteLine($"Título: {contratoRaso.Titulo}");
        Console.WriteLine($"Contratante: {contratoRaso.Contratante.Nome}");
        Console.WriteLine($"Cláusulas: {string.Join(", ", contratoRaso.Clausulas)}");

        Console.WriteLine("\nContrato clonado (profundo):");
        Console.WriteLine($"Título: {contratoProfundo.Titulo}");
        Console.WriteLine($"Contratante: {contratoProfundo.Contratante.Nome}");
        Console.WriteLine($"Cláusulas: {string.Join(", ", contratoProfundo.Clausulas)}");
    }
}