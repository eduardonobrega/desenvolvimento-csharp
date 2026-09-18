namespace Ex06;

public class Ingresso
{
    private string nomeDoShow;
    private double preco;
    private int quantidadeDisponivel;
    
    
    public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
    {
        SetNomeDoShow(nomeDoShow);
        SetPreco(preco);
        SetQuantidadeDisponivel(quantidadeDisponivel);
    }
    
    // Getters 
    public string GetNomeDoShow() => nomeDoShow;
    public double GetPreco() => preco;
    public int GetQuantidadeDisponivel() => quantidadeDisponivel;
   

    // Setters
    public void SetNomeDoShow(string nomeDoShow)
    {
        if (!string.IsNullOrWhiteSpace(nomeDoShow))
        {
            this.nomeDoShow = nomeDoShow;
        }
    }

    public void SetPreco(double preco)
    {
        if (preco > 0)
        {
            this.preco = preco;
        } 
    }

    public void SetQuantidadeDisponivel(int quantidadeDisponivel)
    {
        if (quantidadeDisponivel >= 0)
        {
            this.quantidadeDisponivel = quantidadeDisponivel;
        }
    }
    
    
    public void ExibirInformacoes() 
    {
        Console.WriteLine($"Nome: {this.nomeDoShow} | Preço: R$ {this.preco:F2} | Quantidade Disponivel: {this.quantidadeDisponivel}");
    }
}