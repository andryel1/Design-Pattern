using FacthoryMethod.Interfaces;

namespace FacthoryMethod.Forms
{
    public class Notificacao : INotificacao
    {
        public void Message()
        {
            Console.WriteLine("Nova notificação enviada");
        }
    }
}