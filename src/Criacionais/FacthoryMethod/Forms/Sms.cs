using FacthoryMethod.Interfaces;

namespace FacthoryMethod.Forms
{
    public class Sms : INotificacao
    {
        public void Message()
        {
            Console.WriteLine("Nova mensagem SMS enviada");
        }
    }
}