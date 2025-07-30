namespace abstractFactory.Interface;

public interface IFactoryMethod
{
public INotificacaoEmail CreateNotificacao();
public INotificacaoWhatsapp CreateMessage();
}