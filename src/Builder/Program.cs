using System;
using Builder.Builders;
using Builder.Models;
// using Builder.Viagens; // Removed or comment out this line if it exists
using Builders.Diretor;


class Program
{
  static void Main()
  {
    Console.WriteLine("Fábrica de carro personalizada");
    Console.WriteLine("-------------------------------");

    var carroBuilder1 = new CarroBuilder();
    carroBuilder1.Motor("V8");
    carroBuilder1.Cor("Preto");
    carroBuilder1.ComArCondicionado();
    carroBuilder1.ComSistemaDeSom();
    carroBuilder1.Portas(4);
    var carro1 = carroBuilder1.Build();

    Console.WriteLine("Carro 1:");
    Console.WriteLine($"Motor: {carro1.Motor}");
    Console.WriteLine($"Cor: {carro1.Cor}");
    Console.WriteLine($"Ar Condicionado: {carro1.TemArCondicionado}");
    Console.WriteLine($"Sistema de Som: {carro1.SistemaDeSom}");
    Console.WriteLine($"Portas: {carro1.Portas}");
    Console.WriteLine();

    var carroBuilder2 = new CarroBuilder();
    carroBuilder2.Motor("V6");
    carroBuilder2.Cor("Vermelho");
    carroBuilder2.Portas(2);
    carroBuilder2.SemArCondicionado();
    carroBuilder2.SemSistemaDeSom();
    carroBuilder2.SemTetoSolar();
    var carro2 = carroBuilder2.Build();

    Console.WriteLine("Carro 2:");
    Console.WriteLine($"Motor: {carro2.Motor}");
    Console.WriteLine($"Cor: {carro2.Cor}");
    Console.WriteLine($"Ar Condicionado: {carro2.TemArCondicionado}");
    Console.WriteLine($"Sistema de Som: {carro2.SistemaDeSom}");
    Console.WriteLine($"Portas: {carro2.Portas}");
    Console.WriteLine();

    var casaLuxo = new CasaBuilder();
    casaLuxo.EstruturaDaCasa("Alvenaria");
    casaLuxo.ComGaragem();
    casaLuxo.ComPiscina();
    casaLuxo.ComJardim();
    casaLuxo.Andares(2);
    casaLuxo.Cor("Branca");

    var casa = casaLuxo.Build();
    Console.WriteLine("Casa de Luxo:");
    Console.WriteLine($"Estrutura: {casa.EstruturaDaCasa}");
    Console.WriteLine($"Cor: {casa.Cor}");
    Console.WriteLine($"Garagem: {casa.TemGaragem}");
    Console.WriteLine($"Piscina: {casa.TemPiscina}");
    Console.WriteLine($"Jardim: {casa.TemJardim}");
    Console.WriteLine($"Andares: {casa.Andares}");
    Console.WriteLine();

      var builderSimples = new ViagemSimples();
      var diretorSimples = new ViagemDiretor(builderSimples);

      diretorSimples.Construir("Padrao");
      Viagem viagemCompleta = builderSimples.GetViagem();
      Console.WriteLine("Viagem Completa:");
      Console.WriteLine(viagemCompleta);

      var builderLuxo = new ViagemLuxo();
      var diretorLuxo = new ViagemDiretor(builderLuxo);

      diretorLuxo.Construir("Completo");
      Viagem viagemPadrao = builderLuxo.GetViagem();
      Console.WriteLine("\nViagem Padrão:");
      Console.WriteLine(viagemPadrao);
  }
}
