namespace Ex02;

public class Ingresso
{
    public string NomeDoShow { get; set; } // para identificar o show
    public double Preco { get; set; }     // para saber quanto cobrar do cliente
    public int QuantidadeDisponivel { get; set; } // para saber a quantidade disponivel e se ainda é possivel vender caso seja > 0
}