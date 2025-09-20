using System;
using Estrutural.adapter.Interface;
using Estrutural.adapter.Fornecedor;
using Estrutural.adapter.XmlParaJson;

class Program
{
    static void Main()
    {
        FornecedorXml fornecedor = new FornecedorXml();
        IConversorEspecifico adaptador = new XmlParaJsonAdapter(fornecedor);

        string resultadoJson = adaptador.ObterJson();

        Console.WriteLine("Saída em JSON:");
        Console.WriteLine(resultadoJson);
    }
}