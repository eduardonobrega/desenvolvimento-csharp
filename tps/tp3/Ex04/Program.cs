namespace Ex04;

class Program
{
    static void Main(string[] args)
    {
        Ingresso ingresso = new Ingresso();
        ingresso.nomeDoShow = "Show da xuxa";
        ingresso.preco = 2500;
        ingresso.quantidadeDisponivel = 4;
        
        
        ingresso.AlterarPreco(3000);
        ingresso.AlterarQuantidade(10);
        ingresso.ExibirInformacoes();
    }
}