using FacthoryMethod.Interfaces;

namespace FacthoryMethod.Creators
{
    public abstract class Transformacao
    {
        public abstract INotificacao GetNotification();

        public void EnviarMessage()
        {
            var enviar = GetNotification();
            enviar.Message();
        }
    }
}