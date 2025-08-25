using FacthoryMethod.Interfaces;

namespace FacthoryMethod.Forms
{
    public class BoletoPagamento : IPagamento
    {
        public void Pagamento(int valor)
        {
            Console.WriteLine($"o Valor do boleto foi de: {valor}");
        }
    }
}   