using Sigleton.Bd;
public class Program
{
    public static void Main()
    {
        var conexao = ConexaoBanco.GetConexao();
    }
}