using abstractFactory.Interface;

namespace abstractFactory.AbstractFactory;

public class NotificacaoEmail : INotificacaoEmail
{
 public void Send(string message, string user)
 {
    Console.WriteLine($"Olá, {user}, hoje estou aqui par fazer um comunicado sobre a vaga para {message}. ");
 }
}