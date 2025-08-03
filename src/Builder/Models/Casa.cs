namespace Builders.Models;

public class Casa
{
    public string EstruturaDaCasa { get; set; } = null!;
    public bool TemGaragem { get; set; }
    public bool TemPiscina { get; set; }
    public bool TemJardim { get; set; }
    public int Andares { get; set; }
    public string Cor { get; set; } = null!;

  
}