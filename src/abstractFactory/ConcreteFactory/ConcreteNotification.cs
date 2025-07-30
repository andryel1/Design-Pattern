using abstractFactory.Interface;
using abstractFactory.AbstractFactory;

namespace abstractFactory.ConcreteFactory
{
    public class ConcreteNotification : IFactoryMethod
    {
     public INotificacaoEmail CreateNotificacao()
     {
        return new NotificacaoEmail();
     }
     public INotificacaoWhatsapp CreateMessage()
     {
        return new NotificacaoWhatsapp();
     }
    }
}