using abstractFactory.ConcreteFactory;

var factory = new ConcreteNotification();

var Email = factory.CreateNotificacao();
Email.send("vaga de desenvolvedor C#", "João");

var WhatsApp = factory.CreateMessage();
WhatsApp.send("reunião de equipe", "Maria");