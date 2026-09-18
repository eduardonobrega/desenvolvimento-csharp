namespace Ex03;

public class Ingresso
{
    public string NomeDoShow { get; set; }
    public double Preco { get; private set; }     
    public int QuantidadeDisponivel { get; private set; }
    
    public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
    {
        NomeDoShow = nomeDoShow;
        AlterarPreco(preco);
        AlterarQuantidade(quantidadeDisponivel);
    }

    public void AlterarPreco(double novoPreco)
    {
        if (novoPreco > 0)
        {
           Preco = novoPreco;
        }
    }

    public void AlterarQuantidade(int novaQuantidade)
    {
        if (novaQuantidade >= 0)
        {
            QuantidadeDisponivel = novaQuantidade;
        }
    }
    
    public void ExibirInformacoes() 
    {
        Console.WriteLine($"Nome: {NomeDoShow} | Preço: R$ {Preco:F2} | Quantidade Disponivel: {QuantidadeDisponivel}");
    }
}