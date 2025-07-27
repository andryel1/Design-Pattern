using FacthoryMethod.Interfaces;

namespace FacthoryMethod.Forms
{
    public class CartaoCreditoPagamento : IPagamento
    {
        public void Pagamento(int valor)
        {
            Console.WriteLine($"o Valor pago no cartão foi de: {valor}");
        }
    }
}