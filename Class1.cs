namespace aula11_controlador_acesso
{
    public class Nascimento
    {
    public string nome = "";
    protected int idade;
    public const int anoAtual = 2022;
    protected int anoNascimento;

    public int CalcularAnoNascimento()
    {
        anoNascimento = anoAtual - idade;
        return anoNascimento;
    }
    public void ApresentarUsuario()
    {
        Console.WriteLine($"Olá {nome}, você nasceu em {anoNascimento}");
    }

    public void pegarInput()
    {
        Console.Write("Digite seu Nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade");
        idade = int.Parse(Console.ReadLine());
    }
}
    }