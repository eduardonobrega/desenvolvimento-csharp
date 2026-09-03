namespace _28_08;

public class Pessoa
{
    private string _nome;
    private int _idade;
    
    public string Nome
    {
        get;
        set
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Nome é obrigatório!");
            
            _nome = value;
        }
    }

    public int Idade
    {
        get;
        set
        {
            if (value <= 0 || value > 120) throw new ArgumentOutOfRangeException("Idade inválida");
            
            _idade = value;
        }
    }
}