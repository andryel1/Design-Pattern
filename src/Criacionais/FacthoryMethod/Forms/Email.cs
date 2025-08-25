using FacthoryMethod.Interfaces;

namespace FacthoryMethod.Forms
{
    public class Email : INotificacao
    {
        public void Message()
        {
            Console.WriteLine("Novo email enviado.");
        }
    }
}