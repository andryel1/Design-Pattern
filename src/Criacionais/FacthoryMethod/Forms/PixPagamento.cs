using FacthoryMethod.Interfaces;

namespace FacthoryMethod.Forms
{
    public class PixPagamento : IPagamento
    {
       public void Pagamento(int valor)
        {
            Console.WriteLine($"o Valor do Pix foi de: {valor}");
        }
    }
}