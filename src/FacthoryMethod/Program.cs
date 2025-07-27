using FacthoryMethod.Creators;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Exemplo do Padrão Factory Method ===");
        Console.WriteLine();
        
        Console.WriteLine("");
        var mandandoSms = new SmsCreator();
        mandandoSms.EnviarMessage();
        var preco = new BoletoCreate();
        preco.ReceberPagamento(750);

        Console.WriteLine("");
        var mandandoEmail = new EmailCreator();
        mandandoEmail.EnviarMessage();
        var preco1 = new CartaoCreditoCreate();
        preco1.ReceberPagamento(2000);
      

        Console.WriteLine("");
        var mandandoNotificacao = new NotificacaoCreator();
        mandandoNotificacao.EnviarMessage();
        Console.WriteLine("");
        var preco2 = new PixCreate();
        preco2.ReceberPagamento(100); 
        
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
