namespace Ex04;

class Program
{
    static void Main(string[] args)
    {
        Ingresso ingresso = new Ingresso("Show da xuxa", 4, 2500);
        
        ingresso.AlterarPreco(3000);
        ingresso.AlterarQuantidade(10);
        ingresso.ExibirInformacoes();
    }
}