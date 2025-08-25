using Estrutural.adapter.Interface;
using Estrutural.adapter.Fornecedor;
using System.Xml;
using System.Text.Json;

namespace Estrutural.adapter.XmlParaJson
{
    public class XmlParaJsonAdapter(FornecedorXml fornecedor) : IConversorEspecifico
    {
        private FornecedorXml fornecedor = fornecedor;

        public string ObterJson()
        {
            string xml = fornecedor.ObterXml();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            var pessoaNode = doc.SelectSingleNode("/pessoa");
            var nome = pessoaNode.SelectSingleNode("nome")?.InnerText;
            var idade = pessoaNode.SelectSingleNode("idade")?.InnerText;

            var pessoa = new
            {
                nome = nome,
                idade = idade
            };

            return JsonSerializer.Serialize(pessoa);
        }
    }
}