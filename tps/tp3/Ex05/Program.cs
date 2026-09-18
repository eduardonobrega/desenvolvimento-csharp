namespace Ex05;

class Program
{
    static void Main(string[] args)
    {
        // os metodos gets e sets são uteis pois permite ter acesso/alterar as informações sem acessar ou expor diretamente o atributo
        // com eles posso adicionar validações, fomatações antes de exibir ou alterar
        
        Ingresso ingresso = new Ingresso();
        
        ingresso.SetNomeDoShow("Show da xuxa");
        ingresso.SetQuantidadeDisponivel(4);
        ingresso.SetPreco(200.0);
        
        Console.WriteLine(ingresso.GetPreco());
        ingresso.ExibirInformacoes();
    }
}