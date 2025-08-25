using FacthoryMethod.Interfaces;
using FacthoryMethod.Forms;

namespace FacthoryMethod.Creators
{
    public class NotificacaoCreator : Transformacao
    {
        public override INotificacao GetNotification()
        {
            return new Notificacao();
        }
    }
}