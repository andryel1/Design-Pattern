using FacthoryMethod.Forms;
using FacthoryMethod.Interfaces;

namespace FacthoryMethod.Creators
{
    public class BoletoCreate : PagamentoCreator
    {
        public override IPagamento GetIpagamento()
        {
            return new BoletoPagamento();
        }
    }
}