using FacthoryMethod.Interfaces;

namespace FacthoryMethod.Creators
{
    public abstract class PagamentoCreator
    {
        public abstract IPagamento GetIpagamento();

        public void ReceberPagamento(int valor)
        {
            IPagamento EnviarPagamento = GetIpagamento();
            EnviarPagamento.Pagamento(valor);
        }
    }
}