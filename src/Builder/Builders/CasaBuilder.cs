using Builders.Models;

namespace Builder.Builders;

public class CasaBuilder
{
private Casa _casa = new Casa();

public CasaBuilder EstruturaDaCasa(string EstiloArquitetural)
{
    _casa.EstruturaDaCasa = EstiloArquitetural;
    return this;
}

public CasaBuilder Cor(string CorCasa)
{
    _casa.Cor = CorCasa;
    return this;
}

public CasaBuilder Andares(int Andares)
{
    _casa.Andares = Andares;
    return this;
}

public CasaBuilder ComGaragem()
{
    _casa.TemGaragem = true;
    return this;
}

public CasaBuilder SemGaragem()
{
    _casa.TemGaragem = false;
    return this;
}

public CasaBuilder ComPiscina()
{
    _casa.TemPiscina = true;
    return this;
}

public CasaBuilder SemPiscina()
{
    _casa.TemPiscina = false;
    return this;
}

public CasaBuilder ComJardim()
{
    _casa.TemJardim = true;
    return this;
}

public CasaBuilder SemJardim()
{
    _casa.TemJardim = false;
    return this;
}

public Casa Build()
{
return _casa;
}
}