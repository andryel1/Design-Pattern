namespace Sigleton.Bd;

sealed class ConexaoBanco
{
    private ConexaoBanco()
    {
        Console.WriteLine("Conexão com o banco criada!");
    }

    private static ConexaoBanco _ConexaoBd = null!;

    private static readonly object _lock = new object();
    public static ConexaoBanco GetConexao()
    {
        lock (_lock)
        {
            if (_ConexaoBd == null)
            {
                _ConexaoBd = new ConexaoBanco();
            Console.WriteLine("Conexão criada pela primeira vez!");
        }
        else
        {
            Console.WriteLine("Conexão já existente, reutilizando...");
        }

        return _ConexaoBd;
    }
    }    
}
