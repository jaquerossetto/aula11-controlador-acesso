namespace aula11_controlador_acesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nascimento nasc = new();
            nasc.pegarInput();
            nasc.CalcularAnoNascimento();
            nasc.ApresentarUsuario();
        }
    }
}