using FacthoryMethod.Forms;
using FacthoryMethod.Interfaces;

namespace FacthoryMethod.Creators
{
    public class CartaoCreditoCreate : PagamentoCreator
    {
        public override IPagamento GetIpagamento()
        {
            return new CartaoCreditoPagamento();
        }
    }
}