using abstractFactory.Interface;

namespace abstractFactory.AbstractFactory;

public class NotificacaoWhatsapp : INotificacaoWhatsapp
{
 public void send(string message, string user)
 {
    Console.WriteLine($"Olá, {user}, mensagem via WhatsApp sobre: {message}");
 }
}