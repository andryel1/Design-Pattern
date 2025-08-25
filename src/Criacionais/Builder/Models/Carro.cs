namespace Builder.Models;

public class Carro
{
public int Portas {get; set;}
public bool TemArCondicionado {get; set;}
public bool TemTetoSolar {get; set;}
public bool SistemaDeSom { get; set; }
public string Cor {get; set;} = null!;
public string Motor { get; set; } = null!;

public override string ToString()
{
	return $"Portas: {Portas}, Ar Condicionado: {TemArCondicionado}, Teto Solar: {TemTetoSolar}, Sistema de Som: {SistemaDeSom}, Cor: {Cor}, Motor: {Motor}";
}
}