namespace Ex08;

class Program
{
    static void Main(string[] args)
    {
        Matricula matricula = new Matricula("Eduardo", "ADS", 123);
        matricula.ExibirInformacoes();
        matricula.Trancar();
        matricula.ExibirInformacoes();
    }
}