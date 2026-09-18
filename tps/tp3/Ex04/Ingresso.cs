namespace Ex04;

public class Ingresso
{
    public string nomeDoShow;
    public double preco;
    public int quantidadeDisponivel;
    

    public void AlterarPreco(double novoPreco)
    {
        if (novoPreco > 0)
        {
           this.preco = novoPreco;
        }
    }

    public void AlterarQuantidade(int novaQuantidade)
    {
        if (novaQuantidade >= 0)
        {
            this.quantidadeDisponivel = novaQuantidade;
        }
    }
    
    public void ExibirInformacoes() 
    {
        Console.WriteLine($"Nome: {this.nomeDoShow} | Preço: R$ {this.preco:F2} | Quantidade Disponivel: {this.quantidadeDisponivel}");
    }
}