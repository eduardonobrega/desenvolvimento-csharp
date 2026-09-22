namespace Ex07;

public class ContaBancaria
{
    public string Titular { get; private set; }
    private decimal saldo;

    public ContaBancaria(string titular)
    {
        this.Titular = titular;
        this.saldo = 0;
    }

    public void Depositar(decimal valor)
    {
        
        if (valor < 0)
        {
            Console.WriteLine("O valor do depósito deve ser positivo!");
            return;
        }
        
        saldo += valor;
        Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
    }

    public void Sacar(decimal valor)
    {
        
        if (valor < 0)
        {
            Console.WriteLine("Valor inválido!");
            return;
        }
        
        if (saldo < valor)
        {
            Console.WriteLine($"Tentativa de saque: R$ {valor:F2}");
            Console.WriteLine("Saldo insuficiente para realizar o saque!");    
            return;
        }

        Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
        saldo -= valor;
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
    }
}