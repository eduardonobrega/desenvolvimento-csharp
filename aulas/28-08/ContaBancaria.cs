namespace _28_08;

public class ContaBancaria
{
    public double Saldo {get; private set; }
    public int NumeroConta { get; private set; }
    public string Titular { get; private set; }

    public ContaBancaria(string titular, int numeroConta)
    {
        Titular = titular;
        NumeroConta = numeroConta;
        Saldo = 0;
    }
    
    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor deve ser maior que zero");
        }
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= 0) throw new ArgumentException("Valor inválido");
        if (valor > Saldo) throw new ArgumentException("Saldo insuficiente");
        
        Saldo -= valor;
    }

}