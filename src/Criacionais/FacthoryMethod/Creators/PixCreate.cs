using FacthoryMethod.Forms;
using FacthoryMethod.Interfaces;

namespace FacthoryMethod.Creators
{
    public class PixCreate : PagamentoCreator
    {
        public override IPagamento GetIpagamento()
        {
            return new PixPagamento();
        }
    }
}