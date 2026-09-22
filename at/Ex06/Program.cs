namespace Ex05;

class Program
{
    static void Main(string[] args)
    {
        Aluno a1 = new Aluno("Eduardo", "ads123", "ADS", 8);
        
        a1.ExibirDados();
        Console.WriteLine(a1.VerificarAprovacao());
    }
}